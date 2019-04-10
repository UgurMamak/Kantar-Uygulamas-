using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Kantar
{
    class VtIslemler
    {

        //public const string Baglanti = "Data Source=.;Initial Catalog=VtKantar;User ID=sa;Password=123456;";
        public const string Baglanti = "Data Source=.;Initial Catalog=VtKantar; Integrated Security=True;";
        SqlCommand cmd;
        SqlDataReader reader;
       // SqlDataAdapter da;
        public SqlCommand CreateCommand()//sql ile bağlantıyı sağlaayan fonksiyon
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Baglanti;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }

	// Prosedüre bağlanma işlemi hep tekrarlandığı için connection fonksiyonu yazarak çağırma işlemini gerçekleştirdik.
        public void Connection(string prc)//prosedüre bağlanma işlemi
        {
            cmd = CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = prc;
            if (cmd.Connection.State == ConnectionState.Closed) cmd.Connection.Open();
        }

	
        public SqlDataReader PrcTblCalisanSelect(String KulAdi, String Parola)//Kullanıcı adı veşifre kontrolü
        {
            Connection("PrcTblCalisanSelect");
            cmd.Parameters.AddWithValue("@KulAdi", KulAdi);
            cmd.Parameters.AddWithValue("@Parola", Parola);
            reader = cmd.ExecuteReader();
            return reader;
        }

        public void PrcTblKayitlarInsert(String Plaka, String Sofor, int KulId, int GirisAgirlik, String UrunAd)
        {
            Connection("PrcTblKayitlarInsert");
            cmd.Parameters.AddWithValue("@Plaka", Plaka);
            cmd.Parameters.AddWithValue("@Sofor", Sofor);
            cmd.Parameters.AddWithValue("@KulId", KulId);
            cmd.Parameters.AddWithValue("@GirisAgirlik", GirisAgirlik);
            cmd.Parameters.AddWithValue("@UrunAd", UrunAd);
            cmd.Parameters.AddWithValue("@Durum", 0);
            cmd.ExecuteNonQuery();
        }

        public SqlDataAdapter PrcTblKayitlarSelect()
        {
            SqlDataAdapter day = new SqlDataAdapter("Select tk.IslemId,tk.Plaka,ts.Sofor as 'Şoför',tk.GirisTarihi,tk.GirisAgirlik,tblu.UrunAd as 'Giren Ürün',tc.CalisanAd+' '+tc.CalisanSoyad as 'Kayıt Eden' from TblKayitlar tk join TblSofor ts on tk.SoforId = ts.SoforId join TblCalisan tc on tc.KulId = tk.KulId join  TblUrun tblu on tblu.UrunId=tk.GirenUrun where Durum=0", Baglanti);
            return day;
        }
        public SqlDataAdapter PrcTblKayitlarSelectAnasayfa()
        {
            SqlDataAdapter day = new SqlDataAdapter("Select tk.IslemId,tk.Plaka,ts.Sofor as 'Şoför',tk.GirisTarihi,tc.CalisanAd+' '+tc.CalisanSoyad as 'Kayıt Eden',tk.GirisAgirlik,tu.UrunAd from TblKayitlar tk join TblSofor ts on tk.SoforId = ts.SoforId join TblCalisan tc on tc.KulId = tk.KulId join TblUrun tu on tu.UrunId=tk.GirenUrun where Durum=0", Baglanti);
            return day;
        }
        public void PrcTblKayitlarUpdate(int IslemId, int CikisAgirlik, int UrunAgirlik,String UrunAd)
        {
            Connection("PrcTblKayitlarUpdate");
            cmd.Parameters.AddWithValue("@IslemId", IslemId);
            cmd.Parameters.AddWithValue("@CikisAgirlik", CikisAgirlik);
            cmd.Parameters.AddWithValue("@UrunAgirlik", UrunAgirlik);
            cmd.Parameters.AddWithValue("@UrunAd", UrunAd);
            cmd.ExecuteNonQuery();
        }



        public int PrcAracSayisi()//Kullanıcı adı veşifre kontrolü
        {
            Connection("PrcAracSayisi");
            Int32 count = (Int32)cmd.ExecuteScalar();
            return count;
        }

        public SqlDataReader PrcTblSoforSelect()
        {
            try
            {
                Connection("PrcTblSoforSelect");
                reader = cmd.ExecuteReader();
            }
            catch (Exception) { }
            return reader;
        }

        public SqlDataReader PrcTblUrunSelect()
        {
            try
            {
                Connection("PrcTblUrunSelect");
                reader = cmd.ExecuteReader();
            }
            catch (Exception) { }
            return reader;
        }

        public int PrcPlakaKontrol(string plaka)//Kullanıcı adı veşifre kontrolü
        {
            Connection("PrcPlakaKontrol");
            cmd.Parameters.AddWithValue("@plaka", plaka);
            Int32 count = (Int32)cmd.ExecuteScalar();
            return count;
        }



    }
}
