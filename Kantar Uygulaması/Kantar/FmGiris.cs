using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MetroFramework.Controls;
using MetroFramework;
using System.Data.SqlClient;

namespace Kantar
{
    public partial class FmGiris : MaterialForm
    {
        public FmGiris()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green100, TextShade.WHITE);


        }
        VtIslemler prc = new VtIslemler();
        SqlDataReader reader;
        public static int KulId;
        private void FmGiris_Load(object sender, EventArgs e)
        {
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            bool bosmu = false;

            foreach (Control tb in this.Controls)
            {
                if (tb is MaterialSingleLineTextField && tb.Text == String.Empty) { bosmu = true; break; }// döngü fazla dönmesin diye boş gördüğü andan mesaj vermesini istedim.
            }
            if (bosmu)
                MetroMessageBox.Show(this, "\n Bilgilendirme Mesajı", "BOŞ ALAN BIRAKMAYINIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                reader = prc.PrcTblCalisanSelect(TbKulAdi.Text, TbSifre.Text);//Txt'lere girilen bilgileri class'a gönderdim.
                while (reader.Read())// veritabanından okuma işlemi başarılı olduysa
                {
                    if (reader[0].ToString() == "1")// eğer kullanıcı doğru bilgileri girdiyse dönüş değeri "1" olu yanlış ise "0" değeri döndürür.
                    {
                        KulId = Convert.ToInt32(reader[1].ToString());
                        kontrol = true;
                        FmAnaSayfa yeni = new FmAnaSayfa();// doğru girişte Anasayfa ekranının açılmasını sağladık.
                        yeni.Show();
                        this.Hide();
                        break; // döngü daha fazla dönmesin diye konuldu.               
                    }

                }
                if (!kontrol)
                {
                    MetroMessageBox.Show(this, "\n", "Kullanıcı Adı veya Şifre Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CbGosterGizle_CheckedChanged(object sender, EventArgs e)
        {
            if (CbGosterGizle.Checked == true)
            {
                TbSifre.UseSystemPasswordChar = false;
                CbGosterGizle.Text = "Gizle";
            }
            if (CbGosterGizle.Checked == false)
            {
                TbSifre.UseSystemPasswordChar = true;
                CbGosterGizle.Text = "Göster";
            }
        }
    }
}
