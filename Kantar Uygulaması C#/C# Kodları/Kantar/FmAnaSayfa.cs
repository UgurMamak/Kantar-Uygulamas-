using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// bizim sonradan eklediğimiz kütüphaneler
using MaterialSkin.Controls;
using MaterialSkin;
using MetroFramework.Controls;
using MetroFramework;
using System.Data.Sql;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;


namespace Kantar
{
    public partial class FmAnaSayfa : MaterialForm
    {
        public FmAnaSayfa()
        {
            InitializeComponent();
            // bu kısımda MaterialForm temlarını belirledik.
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
             skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            skinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);

        }
        //Tanımlamalar  ve classları çağırma işlemleri
        VtIslemler prc = new VtIslemler(); // veritabanı bağlantısı ile ilgili işlemleri VtIslemler class'ında toplayıp karmaşıklığı önledik.
      
        SqlDataReader reader;
        SqlCommand cmd;
       // String Tarih, Saat;
        string port;
        int Agirlik; //Tartılan Ağırlığı tutacağımız değişken
        int GirisAgirlik, CikisAgirlik, UrunAgirlik, IslemId;
        
        
        //Araç sayısı bulma işlemini kayıt ekleme ve çıkarma işlemlerinde devamlı yapacağımız için fonksiyon içine yazarak
        //Kod tekrarını önlemiş olduk.
        void FnkAracSayisi()
        {
            LblArac.Text=prc.PrcAracSayisi().ToString();
        }
        
        //Anasayfada Sadece İçeride bulunan araçları listelemek için
        void FnkGirisKayitListele()
        {         
            SqlDataAdapter da = prc.PrcTblKayitlarSelect();
          DataSet  ds = new DataSet();
            da.Fill(ds,"TblKayitlar");
            DgwAnaSayfaKayit1.DataSource = ds.Tables[0];
            DgwCKayit.DataSource = ds.Tables[0];
        }

        //Hangi Portun Takılı olduğunu Bulmak için yazdığımız fonksiyon
        void FnkPortBul()
        {
            for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
            { port = System.IO.Ports.SerialPort.GetPortNames()[i]; }          
            try
            {
                serialPort1.PortName = port;
                if (!serialPort1.IsOpen)serialPort1.Open();
            }
            catch { }
        }

        //Kayıtlı Şoförleri combobox nesnesine yazdırmak için yazdığımız fonksiyon.
        void FnkSoforListele()
        {
            CmbGSofor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CmbRSofor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            reader = prc.PrcTblSoforSelect();
            while (reader.Read())
            {
                veri.Add(reader[1].ToString());
                CmbGSofor.Items.Add(reader[1].ToString());
                CmbGSofor.AutoCompleteCustomSource = veri;
                CmbRSofor.Items.Add(reader[1].ToString());
                CmbRSofor.AutoCompleteCustomSource = veri;
            }
        }

        //Kayıtlı Ürünleri Comboboxa Getirmek için yazdığımız fonksiyon
        void FnkUrunListele()
        {
            CmbGUrun.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CmbCUrun.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            reader = prc.PrcTblUrunSelect();
            while (reader.Read())
            {
                veri.Add(reader[1].ToString());
                CmbGUrun.Items.Add(reader[1].ToString());
                CmbCUrun.Items.Add(reader[1].ToString());
                CmbGUrun.AutoCompleteCustomSource = veri;
                CmbCUrun.AutoCompleteCustomSource = veri;
            }
        }

     
        //Tartma işlemini hem giriş hem çıkış kısmında kullanacağımız için bir fonksiyon içinde yazdık.
        int  FnkTart()
        {
            try
            {
                serialPort1.Write("1");
                Agirlik = Convert.ToInt16(serialPort1.ReadLine());
                System.Threading.Thread.Sleep(100);
            }
            catch (Exception) { }
            return Agirlik;
        }

    
        
        private void FmAnaSayfa_Load(object sender, EventArgs e)
        {

            FnkGirisKayitListele();
            FnkAracSayisi();
            timer1.Start();
            FnkPortBul();
            FnkSoforListele();
            FnkUrunListele();
            FnkTumKayitListele();
            DtTarih1.Format = DateTimePickerFormat.Custom;
            DtTarih1.CustomFormat = "yyyy-MM-dd";
            DtTarih2.Format = DateTimePickerFormat.Custom;
            DtTarih2.CustomFormat = "yyyy-MM-dd";

        }


        
      

        // Tarih ve Saati devamlı güncel tutması için timer nesnesi kullandık.
        private void timer1_Tick(object sender, EventArgs e) { LblTarih.Text = DateTime.Now.ToString(); }

        private void DgwCKayit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TbCPlaka.Text = DgwCKayit.CurrentRow.Cells["Plaka"].Value.ToString();
            TbCSofor.Text = DgwCKayit.CurrentRow.Cells["Şoför"].Value.ToString();
            TbCGirisAgirlik.Text = DgwCKayit.CurrentRow.Cells["GirisAgirlik"].Value.ToString();
            IslemId = Convert.ToInt32(DgwCKayit.CurrentRow.Cells["IslemId"].Value.ToString());

            if (TbCGirisAgirlik.Text == null)
            {
                BtnCTart.Enabled = false;
            }
            else { BtnCTart.Enabled = true; }
        }

      
        
        private void BtnGTart_Click(object sender, EventArgs e)
        {
            LblGirisAgirlik.Text= FnkTart().ToString();
            TbGGirisAgirlik.Text = LblGirisAgirlik.Text;
        }


        private void BtnGKayit_Click(object sender, EventArgs e)
        {
            // İLK  nesnelerin hepsinin dolu olup olmadığını kontrol ettik.
            bool Bosmu =false;
            foreach (Control tb in TpAracGiris.Controls)
            {
                if (tb is MaterialSingleLineTextField && tb.Text == String.Empty) { Bosmu = true; break; }
                if (tb is ComboBox && tb.Text == String.Empty) { Bosmu = true; break; }
            }

            if (Bosmu) MetroMessageBox.Show(this, "\n", "BOŞ ALAN BIRAKMAYINIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //MessageBox.Show("Boş Alan Bırakmayınız.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
            int icerdemi= prc.PrcPlakaKontrol(TbGPlaka.Text);
                if (icerdemi==1)
                {
                    MetroMessageBox.Show(this, "\n", "ARAÇ İÇERİDE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    prc.PrcTblKayitlarInsert(TbGPlaka.Text, CmbGSofor.Text, FmGiris.KulId, Convert.ToInt32(TbGGirisAgirlik.Text), CmbGUrun.Text);
                    MessageBox.Show("Kayıt Edildi");
                    CmbGUrun.Items.Clear();
                    CmbCUrun.Items.Clear();
                    CmbGSofor.Items.Clear();
                    CmbRSofor.Items.Clear();
                    FnkUrunListele();
                    FnkSoforListele();
                    FnkAracSayisi();
                    FnkGirisKayitListele();
                    FnkTumKayitListele();
                    //Kayıt yapıldıktan sonra nesnelerin içini boşaltmak için temizleme işlemi yaptık.
                    foreach (Control tb in TpAracGiris.Controls)
                    {
                        if (tb is MaterialSingleLineTextField) { tb.Text = ""; }
                        if (tb is ComboBox && tb.Text == String.Empty) { tb.Text = ""; }
                    }
                    LblGirisAgirlik.Text = "....Kg";
                }
            }


        }

        private void BtnCTart_Click(object sender, EventArgs e)
        {
            
            LblCikisAgirlik.Text = FnkTart().ToString();
            TbCCikisAgirlik.Text = LblCikisAgirlik.Text;

            CikisAgirlik = Convert.ToInt32(TbCCikisAgirlik.Text);
            GirisAgirlik = Convert.ToInt32(TbCGirisAgirlik.Text);
            UrunAgirlik = CikisAgirlik - GirisAgirlik;          
           TbCUrunAgirlik.Text = UrunAgirlik.ToString();
        }

      

        private void BtnCKayit_Click(object sender, EventArgs e)
        {
            bool Bosmu = false;
            foreach (Control tb in TpAracCikis.Controls)
            {
                if (tb is MaterialSingleLineTextField && tb.Text == String.Empty) { Bosmu = true; break; }
                if (tb is ComboBox && tb.Text == String.Empty) { Bosmu = true; break; }
            }

            if (Bosmu) MetroMessageBox.Show(this, "\n", "BOŞ ALAN BIRAKMAYINIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult dr = MessageBox.Show("Kayıt Yapmak İstediğinizden Emin Misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    prc.PrcTblKayitlarUpdate(IslemId, CikisAgirlik, UrunAgirlik, CmbCUrun.Text);
                    MessageBox.Show("Kayıt Edildi");

                    FnkAracSayisi();//Araç çıkış yaptığında içerideki araç sayısını güncellemek için fonksiyonu tekrar kullandık.
                    FnkGirisKayitListele();
                    FnkTumKayitListele();
                    // Kayıttan sonra nesneleri temizlemek için kullandığım fonksiyon.
                    foreach (Control tb in TpAracCikis.Controls)
                    {
                        if (tb is MaterialSingleLineTextField) { tb.Text = ""; }
                        if (tb is ComboBox && tb.Text == String.Empty) { tb.Text = ""; }
                    }
                    LblCikisAgirlik.Text = "....Kg";
                }
            }
        }

       
        //Grid nesnesine verileri getirirken class'ta hata aldığımız için prosedür işlemlerini burada yaptım.
        void FnkBaglan()
        {
            cmd = prc.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
        }


        //Oturumu kapatma işleminin yapıldığı kısım.
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Oturumu Kapatmak İstediğinizden Emin Misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                FmGiris yeni = new FmGiris();
                yeni.Show();
                this.Close();
            }
        }


        //Datagridview'deki tablonun excell'e aktarmak için yazdığımız kod.
        private void BtnExcel_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
           
            app.Visible = true;
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            sheet1 = workbook.ActiveSheet;
            sheet1.Name = "Exported from gridview";
            for (int i = 1; i < DgwRKayit.Columns.Count + 1; i++)
            {sheet1.Cells[1, i] = DgwRKayit.Columns[i - 1].HeaderText;}

            for (int i = 0; i < DgwRKayit.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DgwRKayit.Columns.Count; j++)
                {sheet1.Cells[i + 2, j + 1] = DgwRKayit.Rows[i].Cells[j].Value.ToString();}
            }
        }

        //Her karakter değişiminde gridviewdeki verilerin güncellenmesi için.
        private void CmbRSofor_TextChanged(object sender, EventArgs e)
        {
            FnkBaglan();
            cmd.CommandText = "PrcSoforFiltre";
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@Sofor", CmbRSofor.Text);//yazılı plakayı gönderme işlemi
            SqlDataAdapter daListele = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            daListele.Fill(ds);
            DgwRKayit.DataSource = ds.Tables[0];
            cmd.Connection.Close();
        }

      

        void FnkTumKayitListele()
        {
            FnkBaglan();
            cmd.CommandText = "PrcTumKayitListele";
            cmd.Connection.Open();
            SqlDataAdapter daListele = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            daListele.Fill(ds);
            DgwRKayit.DataSource = ds.Tables[0];
            cmd.Connection.Close();
        }

        private void RbIceridekiAraclar_CheckedChanged(object sender, EventArgs e){if (RbRIceridekiAraclar.Checked == true) FnkDurumListele(0);}

        private void RbRCikisYapanlar_CheckedChanged(object sender, EventArgs e)
        {
            if (RbRCikisYapanlar.Checked == true) FnkDurumListele(1);
        }

        private void RbRTumKayitlar_CheckedChanged(object sender, EventArgs e)
        {
            if (RbRTumKayitlar.Checked == true) FnkTumKayitListele();
        }

       

        //Plaka karakter uzunluğunu 10 olarak verdik. eğer 10 a ulaşırsa plaka textbox'ına daha fazla yazzı giremeyecek.
        private void TbGPlaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TbGPlaka.TextLength == 10)
            {
                e.Handled = true;
            }
           if(e.KeyChar == (char)Keys.Back)            
                e.Handled = false;
            
        }
        //Plakayı girmeye başlayınca uygun olan kayıtlar listelenir.
        private void TbRPlaka_TextChanged(object sender, EventArgs e)
        {
            FnkBaglan();
            cmd.CommandText = "PrcPlakaFiltre";
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@Plaka", TbRPlaka.Text);//yazılı plakayı gönderme işlemi
            SqlDataAdapter daListele = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            daListele.Fill(ds);
            DgwRKayit.DataSource = ds.Tables[0];
            cmd.Connection.Close();
        }
        private void BtnTarih_Click(object sender, EventArgs e)
        {
            FnkBaglan();
            cmd.CommandText = "PrcTarihRapor";
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@Tarih1", DtTarih1.Text);//yazılı plakayı gönderme işlemi
            cmd.Parameters.AddWithValue("@Tarih2", DtTarih2.Text);
            SqlDataAdapter daListele = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            daListele.Fill(ds);
            DgwRKayit.DataSource = ds.Tables[0];
            cmd.Connection.Close();
        }
        void FnkDurumListele(int durum)
        {
            FnkBaglan();
            cmd.CommandText = "PrcDurumFiltre";
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@Durum", durum);
            SqlDataAdapter daListele = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            daListele.Fill(ds);
            DgwRKayit.DataSource = ds.Tables[0];
            cmd.Connection.Close();
        }

    }
}
