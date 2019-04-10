namespace Kantar
{
    partial class FmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAnaSayfa));
            this.TapControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TpAnaSayfa = new System.Windows.Forms.TabPage();
            this.LblArac = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.DgwAnaSayfaKayit1 = new MetroFramework.Controls.MetroGrid();
            this.TpAracGiris = new System.Windows.Forms.TabPage();
            this.CmbGUrun = new System.Windows.Forms.ComboBox();
            this.TbGGirisAgirlik = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CmbGSofor = new System.Windows.Forms.ComboBox();
            this.TbGPlaka = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.TpAracCikis = new System.Windows.Forms.TabPage();
            this.DgwCKayit = new MetroFramework.Controls.MetroGrid();
            this.TbCSofor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TbCPlaka = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TbCUrunAgirlik = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TbCCikisAgirlik = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TbCGirisAgirlik = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CmbCUrun = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.TpRapor = new System.Windows.Forms.TabPage();
            this.RbRTumKayitlar = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbRCikisYapanlar = new MaterialSkin.Controls.MaterialRadioButton();
            this.RbRIceridekiAraclar = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.CmbRSofor = new System.Windows.Forms.ComboBox();
            this.TbRPlaka = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.DtTarih2 = new MetroFramework.Controls.MetroDateTime();
            this.DtTarih1 = new MetroFramework.Controls.MetroDateTime();
            this.DgwRKayit = new MetroFramework.Controls.MetroGrid();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.BtnKapat = new MaterialSkin.Controls.MaterialRaisedButton();
            this.iTalk_ControlBox1 = new iTalk.iTalk_ControlBox();
            this.LblTarih = new iTalk.iTalk_HeaderLabel();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.LblGirisAgirlik = new iTalk.iTalk_HeaderLabel();
            this.BtnGKayit = new iTalk.iTalk_Button_1();
            this.BtnGTart = new iTalk.iTalk_Button_1();
            this.iTalk_HeaderLabel2 = new iTalk.iTalk_HeaderLabel();
            this.BtnCKayit = new iTalk.iTalk_Button_1();
            this.BtnCTart = new iTalk.iTalk_Button_1();
            this.LblCikisAgirlik = new iTalk.iTalk_HeaderLabel();
            this.BtnExcel = new iTalk.iTalk_Button_1();
            this.BtnTarih = new iTalk.iTalk_Button_1();
            this.TapControl.SuspendLayout();
            this.TpAnaSayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwAnaSayfaKayit1)).BeginInit();
            this.TpAracGiris.SuspendLayout();
            this.TpAracCikis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwCKayit)).BeginInit();
            this.TpRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwRKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // TapControl
            // 
            this.TapControl.Controls.Add(this.TpAnaSayfa);
            this.TapControl.Controls.Add(this.TpAracGiris);
            this.TapControl.Controls.Add(this.TpAracCikis);
            this.TapControl.Controls.Add(this.TpRapor);
            this.TapControl.Depth = 0;
            this.TapControl.Location = new System.Drawing.Point(1, 93);
            this.TapControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TapControl.Name = "TapControl";
            this.TapControl.SelectedIndex = 0;
            this.TapControl.Size = new System.Drawing.Size(1197, 458);
            this.TapControl.TabIndex = 0;
            // 
            // TpAnaSayfa
            // 
            this.TpAnaSayfa.Controls.Add(this.LblArac);
            this.TpAnaSayfa.Controls.Add(this.materialLabel1);
            this.TpAnaSayfa.Controls.Add(this.DgwAnaSayfaKayit1);
            this.TpAnaSayfa.Location = new System.Drawing.Point(4, 22);
            this.TpAnaSayfa.Name = "TpAnaSayfa";
            this.TpAnaSayfa.Padding = new System.Windows.Forms.Padding(3);
            this.TpAnaSayfa.Size = new System.Drawing.Size(1189, 432);
            this.TpAnaSayfa.TabIndex = 0;
            this.TpAnaSayfa.Text = "AnaSayfa";
            this.TpAnaSayfa.UseVisualStyleBackColor = true;
            // 
            // LblArac
            // 
            this.LblArac.AutoSize = true;
            this.LblArac.Depth = 0;
            this.LblArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LblArac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblArac.Location = new System.Drawing.Point(569, 25);
            this.LblArac.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblArac.Name = "LblArac";
            this.LblArac.Size = new System.Drawing.Size(103, 18);
            this.LblArac.TabIndex = 2;
            this.LblArac.Text = "materialLabel2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(373, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(185, 18);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "İçeride Bulunan Araç Sayısı";
            // 
            // DgwAnaSayfaKayit1
            // 
            this.DgwAnaSayfaKayit1.AllowUserToResizeRows = false;
            this.DgwAnaSayfaKayit1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwAnaSayfaKayit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgwAnaSayfaKayit1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgwAnaSayfaKayit1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwAnaSayfaKayit1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgwAnaSayfaKayit1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwAnaSayfaKayit1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgwAnaSayfaKayit1.EnableHeadersVisualStyles = false;
            this.DgwAnaSayfaKayit1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgwAnaSayfaKayit1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwAnaSayfaKayit1.Location = new System.Drawing.Point(57, 81);
            this.DgwAnaSayfaKayit1.Name = "DgwAnaSayfaKayit1";
            this.DgwAnaSayfaKayit1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwAnaSayfaKayit1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgwAnaSayfaKayit1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgwAnaSayfaKayit1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgwAnaSayfaKayit1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwAnaSayfaKayit1.Size = new System.Drawing.Size(955, 338);
            this.DgwAnaSayfaKayit1.Style = MetroFramework.MetroColorStyle.Green;
            this.DgwAnaSayfaKayit1.TabIndex = 0;
            this.DgwAnaSayfaKayit1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TpAracGiris
            // 
            this.TpAracGiris.BackColor = System.Drawing.Color.White;
            this.TpAracGiris.Controls.Add(this.iTalk_HeaderLabel1);
            this.TpAracGiris.Controls.Add(this.LblGirisAgirlik);
            this.TpAracGiris.Controls.Add(this.BtnGKayit);
            this.TpAracGiris.Controls.Add(this.BtnGTart);
            this.TpAracGiris.Controls.Add(this.CmbGUrun);
            this.TpAracGiris.Controls.Add(this.TbGGirisAgirlik);
            this.TpAracGiris.Controls.Add(this.CmbGSofor);
            this.TpAracGiris.Controls.Add(this.TbGPlaka);
            this.TpAracGiris.Controls.Add(this.materialLabel4);
            this.TpAracGiris.Controls.Add(this.materialLabel3);
            this.TpAracGiris.Controls.Add(this.materialLabel2);
            this.TpAracGiris.Controls.Add(this.materialLabel5);
            this.TpAracGiris.Location = new System.Drawing.Point(4, 22);
            this.TpAracGiris.Name = "TpAracGiris";
            this.TpAracGiris.Padding = new System.Windows.Forms.Padding(3);
            this.TpAracGiris.Size = new System.Drawing.Size(1189, 432);
            this.TpAracGiris.TabIndex = 1;
            this.TpAracGiris.Text = "Araç Giriş";
            // 
            // CmbGUrun
            // 
            this.CmbGUrun.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbGUrun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CmbGUrun.FormattingEnabled = true;
            this.CmbGUrun.Location = new System.Drawing.Point(766, 209);
            this.CmbGUrun.Name = "CmbGUrun";
            this.CmbGUrun.Size = new System.Drawing.Size(169, 21);
            this.CmbGUrun.TabIndex = 22;
            // 
            // TbGGirisAgirlik
            // 
            this.TbGGirisAgirlik.Depth = 0;
            this.TbGGirisAgirlik.Enabled = false;
            this.TbGGirisAgirlik.Hint = "";
            this.TbGGirisAgirlik.Location = new System.Drawing.Point(766, 165);
            this.TbGGirisAgirlik.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbGGirisAgirlik.Name = "TbGGirisAgirlik";
            this.TbGGirisAgirlik.PasswordChar = '\0';
            this.TbGGirisAgirlik.SelectedText = "";
            this.TbGGirisAgirlik.SelectionLength = 0;
            this.TbGGirisAgirlik.SelectionStart = 0;
            this.TbGGirisAgirlik.Size = new System.Drawing.Size(169, 23);
            this.TbGGirisAgirlik.TabIndex = 21;
            this.TbGGirisAgirlik.UseSystemPasswordChar = false;
            // 
            // CmbGSofor
            // 
            this.CmbGSofor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbGSofor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CmbGSofor.FormattingEnabled = true;
            this.CmbGSofor.Location = new System.Drawing.Point(375, 206);
            this.CmbGSofor.Name = "CmbGSofor";
            this.CmbGSofor.Size = new System.Drawing.Size(169, 21);
            this.CmbGSofor.TabIndex = 20;
            // 
            // TbGPlaka
            // 
            this.TbGPlaka.Depth = 0;
            this.TbGPlaka.Hint = "";
            this.TbGPlaka.Location = new System.Drawing.Point(375, 165);
            this.TbGPlaka.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbGPlaka.Name = "TbGPlaka";
            this.TbGPlaka.PasswordChar = '\0';
            this.TbGPlaka.SelectedText = "";
            this.TbGPlaka.SelectionLength = 0;
            this.TbGPlaka.SelectionStart = 0;
            this.TbGPlaka.Size = new System.Drawing.Size(169, 23);
            this.TbGPlaka.TabIndex = 19;
            this.TbGPlaka.UseSystemPasswordChar = false;
            this.TbGPlaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbGPlaka_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(612, 209);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 18);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Ürün";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(612, 169);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 18);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Giriş Ağırlık";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(221, 208);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 18);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Şoför ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(221, 169);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(45, 18);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Plaka";
            // 
            // TpAracCikis
            // 
            this.TpAracCikis.BackColor = System.Drawing.Color.White;
            this.TpAracCikis.Controls.Add(this.iTalk_HeaderLabel2);
            this.TpAracCikis.Controls.Add(this.BtnCKayit);
            this.TpAracCikis.Controls.Add(this.BtnCTart);
            this.TpAracCikis.Controls.Add(this.DgwCKayit);
            this.TpAracCikis.Controls.Add(this.TbCSofor);
            this.TpAracCikis.Controls.Add(this.TbCPlaka);
            this.TpAracCikis.Controls.Add(this.TbCUrunAgirlik);
            this.TpAracCikis.Controls.Add(this.TbCCikisAgirlik);
            this.TpAracCikis.Controls.Add(this.TbCGirisAgirlik);
            this.TpAracCikis.Controls.Add(this.CmbCUrun);
            this.TpAracCikis.Controls.Add(this.materialLabel6);
            this.TpAracCikis.Controls.Add(this.materialLabel7);
            this.TpAracCikis.Controls.Add(this.materialLabel8);
            this.TpAracCikis.Controls.Add(this.materialLabel9);
            this.TpAracCikis.Controls.Add(this.materialLabel10);
            this.TpAracCikis.Controls.Add(this.materialLabel11);
            this.TpAracCikis.Controls.Add(this.LblCikisAgirlik);
            this.TpAracCikis.Location = new System.Drawing.Point(4, 22);
            this.TpAracCikis.Name = "TpAracCikis";
            this.TpAracCikis.Padding = new System.Windows.Forms.Padding(3);
            this.TpAracCikis.Size = new System.Drawing.Size(1189, 432);
            this.TpAracCikis.TabIndex = 2;
            this.TpAracCikis.Text = "Araç Çıkış";
            // 
            // DgwCKayit
            // 
            this.DgwCKayit.AllowUserToResizeRows = false;
            this.DgwCKayit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwCKayit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgwCKayit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgwCKayit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwCKayit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgwCKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwCKayit.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgwCKayit.EnableHeadersVisualStyles = false;
            this.DgwCKayit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgwCKayit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwCKayit.Location = new System.Drawing.Point(89, 208);
            this.DgwCKayit.Name = "DgwCKayit";
            this.DgwCKayit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwCKayit.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgwCKayit.RowHeadersWidth = 60;
            this.DgwCKayit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgwCKayit.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgwCKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwCKayit.Size = new System.Drawing.Size(972, 228);
            this.DgwCKayit.Style = MetroFramework.MetroColorStyle.Green;
            this.DgwCKayit.TabIndex = 34;
            this.DgwCKayit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgwCKayit_CellContentClick);
            // 
            // TbCSofor
            // 
            this.TbCSofor.Depth = 0;
            this.TbCSofor.Enabled = false;
            this.TbCSofor.Hint = "";
            this.TbCSofor.Location = new System.Drawing.Point(382, 90);
            this.TbCSofor.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbCSofor.Name = "TbCSofor";
            this.TbCSofor.PasswordChar = '\0';
            this.TbCSofor.SelectedText = "";
            this.TbCSofor.SelectionLength = 0;
            this.TbCSofor.SelectionStart = 0;
            this.TbCSofor.Size = new System.Drawing.Size(152, 23);
            this.TbCSofor.TabIndex = 32;
            this.TbCSofor.UseSystemPasswordChar = false;
            // 
            // TbCPlaka
            // 
            this.TbCPlaka.Depth = 0;
            this.TbCPlaka.Enabled = false;
            this.TbCPlaka.Hint = "";
            this.TbCPlaka.Location = new System.Drawing.Point(382, 60);
            this.TbCPlaka.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbCPlaka.Name = "TbCPlaka";
            this.TbCPlaka.PasswordChar = '\0';
            this.TbCPlaka.SelectedText = "";
            this.TbCPlaka.SelectionLength = 0;
            this.TbCPlaka.SelectionStart = 0;
            this.TbCPlaka.Size = new System.Drawing.Size(152, 23);
            this.TbCPlaka.TabIndex = 31;
            this.TbCPlaka.UseSystemPasswordChar = false;
            // 
            // TbCUrunAgirlik
            // 
            this.TbCUrunAgirlik.Depth = 0;
            this.TbCUrunAgirlik.Enabled = false;
            this.TbCUrunAgirlik.Hint = "";
            this.TbCUrunAgirlik.Location = new System.Drawing.Point(693, 127);
            this.TbCUrunAgirlik.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbCUrunAgirlik.Name = "TbCUrunAgirlik";
            this.TbCUrunAgirlik.PasswordChar = '\0';
            this.TbCUrunAgirlik.SelectedText = "";
            this.TbCUrunAgirlik.SelectionLength = 0;
            this.TbCUrunAgirlik.SelectionStart = 0;
            this.TbCUrunAgirlik.Size = new System.Drawing.Size(146, 23);
            this.TbCUrunAgirlik.TabIndex = 30;
            this.TbCUrunAgirlik.UseSystemPasswordChar = false;
            // 
            // TbCCikisAgirlik
            // 
            this.TbCCikisAgirlik.Depth = 0;
            this.TbCCikisAgirlik.Enabled = false;
            this.TbCCikisAgirlik.Hint = "";
            this.TbCCikisAgirlik.Location = new System.Drawing.Point(693, 94);
            this.TbCCikisAgirlik.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbCCikisAgirlik.Name = "TbCCikisAgirlik";
            this.TbCCikisAgirlik.PasswordChar = '\0';
            this.TbCCikisAgirlik.SelectedText = "";
            this.TbCCikisAgirlik.SelectionLength = 0;
            this.TbCCikisAgirlik.SelectionStart = 0;
            this.TbCCikisAgirlik.Size = new System.Drawing.Size(146, 23);
            this.TbCCikisAgirlik.TabIndex = 29;
            this.TbCCikisAgirlik.UseSystemPasswordChar = false;
            // 
            // TbCGirisAgirlik
            // 
            this.TbCGirisAgirlik.Depth = 0;
            this.TbCGirisAgirlik.Enabled = false;
            this.TbCGirisAgirlik.Hint = "";
            this.TbCGirisAgirlik.Location = new System.Drawing.Point(693, 60);
            this.TbCGirisAgirlik.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbCGirisAgirlik.Name = "TbCGirisAgirlik";
            this.TbCGirisAgirlik.PasswordChar = '\0';
            this.TbCGirisAgirlik.SelectedText = "";
            this.TbCGirisAgirlik.SelectionLength = 0;
            this.TbCGirisAgirlik.SelectionStart = 0;
            this.TbCGirisAgirlik.Size = new System.Drawing.Size(146, 23);
            this.TbCGirisAgirlik.TabIndex = 28;
            this.TbCGirisAgirlik.UseSystemPasswordChar = false;
            // 
            // CmbCUrun
            // 
            this.CmbCUrun.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbCUrun.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CmbCUrun.FormattingEnabled = true;
            this.CmbCUrun.Location = new System.Drawing.Point(382, 132);
            this.CmbCUrun.Name = "CmbCUrun";
            this.CmbCUrun.Size = new System.Drawing.Size(152, 21);
            this.CmbCUrun.TabIndex = 27;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(293, 132);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(40, 18);
            this.materialLabel6.TabIndex = 26;
            this.materialLabel6.Text = "Ürün";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(566, 127);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(83, 18);
            this.materialLabel7.TabIndex = 25;
            this.materialLabel7.Text = "Ürün Ağırlık";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(566, 94);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(84, 18);
            this.materialLabel8.TabIndex = 24;
            this.materialLabel8.Text = "Çıkış Ağırlık";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(566, 60);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(82, 18);
            this.materialLabel9.TabIndex = 23;
            this.materialLabel9.Text = "Giriş Ağırlık";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(293, 97);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(45, 18);
            this.materialLabel10.TabIndex = 22;
            this.materialLabel10.Text = "Şoför";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(293, 63);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(45, 18);
            this.materialLabel11.TabIndex = 21;
            this.materialLabel11.Text = "Plaka";
            // 
            // TpRapor
            // 
            this.TpRapor.BackColor = System.Drawing.Color.White;
            this.TpRapor.Controls.Add(this.RbRTumKayitlar);
            this.TpRapor.Controls.Add(this.RbRCikisYapanlar);
            this.TpRapor.Controls.Add(this.RbRIceridekiAraclar);
            this.TpRapor.Controls.Add(this.materialLabel13);
            this.TpRapor.Controls.Add(this.CmbRSofor);
            this.TpRapor.Controls.Add(this.TbRPlaka);
            this.TpRapor.Controls.Add(this.materialLabel12);
            this.TpRapor.Controls.Add(this.DtTarih2);
            this.TpRapor.Controls.Add(this.DtTarih1);
            this.TpRapor.Controls.Add(this.DgwRKayit);
            this.TpRapor.Controls.Add(this.BtnExcel);
            this.TpRapor.Controls.Add(this.BtnTarih);
            this.TpRapor.Location = new System.Drawing.Point(4, 22);
            this.TpRapor.Name = "TpRapor";
            this.TpRapor.Padding = new System.Windows.Forms.Padding(3);
            this.TpRapor.Size = new System.Drawing.Size(1189, 432);
            this.TpRapor.TabIndex = 3;
            this.TpRapor.Text = "Rapor";
            // 
            // RbRTumKayitlar
            // 
            this.RbRTumKayitlar.AutoSize = true;
            this.RbRTumKayitlar.Depth = 0;
            this.RbRTumKayitlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RbRTumKayitlar.Location = new System.Drawing.Point(676, 50);
            this.RbRTumKayitlar.Margin = new System.Windows.Forms.Padding(0);
            this.RbRTumKayitlar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbRTumKayitlar.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbRTumKayitlar.Name = "RbRTumKayitlar";
            this.RbRTumKayitlar.Ripple = true;
            this.RbRTumKayitlar.Size = new System.Drawing.Size(64, 30);
            this.RbRTumKayitlar.TabIndex = 11;
            this.RbRTumKayitlar.TabStop = true;
            this.RbRTumKayitlar.Text = "Tümü";
            this.RbRTumKayitlar.UseVisualStyleBackColor = true;
            this.RbRTumKayitlar.CheckedChanged += new System.EventHandler(this.RbRTumKayitlar_CheckedChanged);
            // 
            // RbRCikisYapanlar
            // 
            this.RbRCikisYapanlar.AutoSize = true;
            this.RbRCikisYapanlar.Depth = 0;
            this.RbRCikisYapanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RbRCikisYapanlar.Location = new System.Drawing.Point(676, 26);
            this.RbRCikisYapanlar.Margin = new System.Windows.Forms.Padding(0);
            this.RbRCikisYapanlar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbRCikisYapanlar.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbRCikisYapanlar.Name = "RbRCikisYapanlar";
            this.RbRCikisYapanlar.Ripple = true;
            this.RbRCikisYapanlar.Size = new System.Drawing.Size(117, 30);
            this.RbRCikisYapanlar.TabIndex = 10;
            this.RbRCikisYapanlar.TabStop = true;
            this.RbRCikisYapanlar.Text = "Çıkış Yapanlar";
            this.RbRCikisYapanlar.UseVisualStyleBackColor = true;
            this.RbRCikisYapanlar.CheckedChanged += new System.EventHandler(this.RbRCikisYapanlar_CheckedChanged);
            // 
            // RbRIceridekiAraclar
            // 
            this.RbRIceridekiAraclar.AutoSize = true;
            this.RbRIceridekiAraclar.Depth = 0;
            this.RbRIceridekiAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RbRIceridekiAraclar.Location = new System.Drawing.Point(676, 0);
            this.RbRIceridekiAraclar.Margin = new System.Windows.Forms.Padding(0);
            this.RbRIceridekiAraclar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RbRIceridekiAraclar.MouseState = MaterialSkin.MouseState.HOVER;
            this.RbRIceridekiAraclar.Name = "RbRIceridekiAraclar";
            this.RbRIceridekiAraclar.Ripple = true;
            this.RbRIceridekiAraclar.Size = new System.Drawing.Size(129, 30);
            this.RbRIceridekiAraclar.TabIndex = 9;
            this.RbRIceridekiAraclar.TabStop = true;
            this.RbRIceridekiAraclar.Text = "İçerideki Araçlar";
            this.RbRIceridekiAraclar.UseVisualStyleBackColor = true;
            this.RbRIceridekiAraclar.CheckedChanged += new System.EventHandler(this.RbIceridekiAraclar_CheckedChanged);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(428, 43);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(45, 18);
            this.materialLabel13.TabIndex = 8;
            this.materialLabel13.Text = "Şoför";
            // 
            // CmbRSofor
            // 
            this.CmbRSofor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbRSofor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CmbRSofor.FormattingEnabled = true;
            this.CmbRSofor.Location = new System.Drawing.Point(481, 44);
            this.CmbRSofor.Name = "CmbRSofor";
            this.CmbRSofor.Size = new System.Drawing.Size(155, 21);
            this.CmbRSofor.TabIndex = 7;
            this.CmbRSofor.TextChanged += new System.EventHandler(this.CmbRSofor_TextChanged);
            // 
            // TbRPlaka
            // 
            this.TbRPlaka.Depth = 0;
            this.TbRPlaka.Hint = "";
            this.TbRPlaka.Location = new System.Drawing.Point(481, 6);
            this.TbRPlaka.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbRPlaka.Name = "TbRPlaka";
            this.TbRPlaka.PasswordChar = '\0';
            this.TbRPlaka.SelectedText = "";
            this.TbRPlaka.SelectionLength = 0;
            this.TbRPlaka.SelectionStart = 0;
            this.TbRPlaka.Size = new System.Drawing.Size(155, 23);
            this.TbRPlaka.TabIndex = 5;
            this.TbRPlaka.UseSystemPasswordChar = false;
            this.TbRPlaka.TextChanged += new System.EventHandler(this.TbRPlaka_TextChanged);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(429, 6);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(45, 18);
            this.materialLabel12.TabIndex = 4;
            this.materialLabel12.Text = "Plaka";
            // 
            // DtTarih2
            // 
            this.DtTarih2.Location = new System.Drawing.Point(279, 6);
            this.DtTarih2.MinimumSize = new System.Drawing.Size(4, 29);
            this.DtTarih2.Name = "DtTarih2";
            this.DtTarih2.Size = new System.Drawing.Size(118, 29);
            this.DtTarih2.TabIndex = 2;
            // 
            // DtTarih1
            // 
            this.DtTarih1.Location = new System.Drawing.Point(145, 6);
            this.DtTarih1.MinimumSize = new System.Drawing.Size(4, 29);
            this.DtTarih1.Name = "DtTarih1";
            this.DtTarih1.Size = new System.Drawing.Size(118, 29);
            this.DtTarih1.TabIndex = 1;
            // 
            // DgwRKayit
            // 
            this.DgwRKayit.AllowUserToResizeRows = false;
            this.DgwRKayit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwRKayit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgwRKayit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgwRKayit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwRKayit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgwRKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgwRKayit.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgwRKayit.EnableHeadersVisualStyles = false;
            this.DgwRKayit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgwRKayit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgwRKayit.Location = new System.Drawing.Point(1, 84);
            this.DgwRKayit.Name = "DgwRKayit";
            this.DgwRKayit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgwRKayit.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgwRKayit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgwRKayit.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DgwRKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgwRKayit.Size = new System.Drawing.Size(1182, 348);
            this.DgwRKayit.Style = MetroFramework.MetroColorStyle.Green;
            this.DgwRKayit.TabIndex = 0;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.TapControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.materialTabSelector1.Location = new System.Drawing.Point(-7, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1205, 30);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnKapat
            // 
            this.BtnKapat.Depth = 0;
            this.BtnKapat.Location = new System.Drawing.Point(1123, 24);
            this.BtnKapat.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Primary = true;
            this.BtnKapat.Size = new System.Drawing.Size(75, 23);
            this.BtnKapat.TabIndex = 3;
            this.BtnKapat.Text = "KAPAT";
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // iTalk_ControlBox1
            // 
            this.iTalk_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iTalk_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ControlBox1.Location = new System.Drawing.Point(1121, -1);
            this.iTalk_ControlBox1.Name = "iTalk_ControlBox1";
            this.iTalk_ControlBox1.Size = new System.Drawing.Size(77, 19);
            this.iTalk_ControlBox1.TabIndex = 38;
            this.iTalk_ControlBox1.Text = "iTalk_ControlBox1";
            // 
            // LblTarih
            // 
            this.LblTarih.AutoSize = true;
            this.LblTarih.BackColor = System.Drawing.Color.Transparent;
            this.LblTarih.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTarih.ForeColor = System.Drawing.Color.White;
            this.LblTarih.Location = new System.Drawing.Point(3, 26);
            this.LblTarih.Name = "LblTarih";
            this.LblTarih.Size = new System.Drawing.Size(126, 17);
            this.LblTarih.TabIndex = 37;
            this.LblTarih.Text = "iTalk_HeaderLabel1";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(443, 0);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(209, 46);
            this.iTalk_HeaderLabel1.TabIndex = 28;
            this.iTalk_HeaderLabel1.Text = "Araç Ağırlığı:";
            // 
            // LblGirisAgirlik
            // 
            this.LblGirisAgirlik.AutoSize = true;
            this.LblGirisAgirlik.BackColor = System.Drawing.Color.Transparent;
            this.LblGirisAgirlik.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.LblGirisAgirlik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LblGirisAgirlik.Location = new System.Drawing.Point(646, 0);
            this.LblGirisAgirlik.Name = "LblGirisAgirlik";
            this.LblGirisAgirlik.Size = new System.Drawing.Size(88, 46);
            this.LblGirisAgirlik.TabIndex = 27;
            this.LblGirisAgirlik.Text = "....Kg";
            // 
            // BtnGKayit
            // 
            this.BtnGKayit.BackColor = System.Drawing.Color.Transparent;
            this.BtnGKayit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnGKayit.Image = ((System.Drawing.Image)(resources.GetObject("BtnGKayit.Image")));
            this.BtnGKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGKayit.Location = new System.Drawing.Point(754, 243);
            this.BtnGKayit.Name = "BtnGKayit";
            this.BtnGKayit.Size = new System.Drawing.Size(181, 45);
            this.BtnGKayit.TabIndex = 26;
            this.BtnGKayit.Text = "Kayıt Et";
            this.BtnGKayit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnGKayit.Click += new System.EventHandler(this.BtnGKayit_Click);
            // 
            // BtnGTart
            // 
            this.BtnGTart.BackColor = System.Drawing.Color.Transparent;
            this.BtnGTart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnGTart.Image = ((System.Drawing.Image)(resources.GetObject("BtnGTart.Image")));
            this.BtnGTart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGTart.Location = new System.Drawing.Point(375, 243);
            this.BtnGTart.Name = "BtnGTart";
            this.BtnGTart.Size = new System.Drawing.Size(169, 45);
            this.BtnGTart.TabIndex = 25;
            this.BtnGTart.Text = "Tart";
            this.BtnGTart.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnGTart.Click += new System.EventHandler(this.BtnGTart_Click);
            // 
            // iTalk_HeaderLabel2
            // 
            this.iTalk_HeaderLabel2.AutoSize = true;
            this.iTalk_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.iTalk_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel2.Location = new System.Drawing.Point(395, 3);
            this.iTalk_HeaderLabel2.Name = "iTalk_HeaderLabel2";
            this.iTalk_HeaderLabel2.Size = new System.Drawing.Size(209, 46);
            this.iTalk_HeaderLabel2.TabIndex = 37;
            this.iTalk_HeaderLabel2.Text = "Araç Ağırlığı:";
            // 
            // BtnCKayit
            // 
            this.BtnCKayit.BackColor = System.Drawing.Color.Transparent;
            this.BtnCKayit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCKayit.Image = ((System.Drawing.Image)(resources.GetObject("BtnCKayit.Image")));
            this.BtnCKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCKayit.Location = new System.Drawing.Point(693, 157);
            this.BtnCKayit.Name = "BtnCKayit";
            this.BtnCKayit.Size = new System.Drawing.Size(146, 40);
            this.BtnCKayit.TabIndex = 36;
            this.BtnCKayit.Text = "Kayıt Et";
            this.BtnCKayit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnCKayit.Click += new System.EventHandler(this.BtnCKayit_Click);
            // 
            // BtnCTart
            // 
            this.BtnCTart.BackColor = System.Drawing.Color.Transparent;
            this.BtnCTart.Enabled = false;
            this.BtnCTart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnCTart.Image = ((System.Drawing.Image)(resources.GetObject("BtnCTart.Image")));
            this.BtnCTart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCTart.Location = new System.Drawing.Point(382, 162);
            this.BtnCTart.Name = "BtnCTart";
            this.BtnCTart.Size = new System.Drawing.Size(152, 38);
            this.BtnCTart.TabIndex = 35;
            this.BtnCTart.Text = "Tart";
            this.BtnCTart.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnCTart.Click += new System.EventHandler(this.BtnCTart_Click);
            // 
            // LblCikisAgirlik
            // 
            this.LblCikisAgirlik.AutoSize = true;
            this.LblCikisAgirlik.BackColor = System.Drawing.Color.Transparent;
            this.LblCikisAgirlik.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.LblCikisAgirlik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LblCikisAgirlik.Location = new System.Drawing.Point(597, 3);
            this.LblCikisAgirlik.Name = "LblCikisAgirlik";
            this.LblCikisAgirlik.Size = new System.Drawing.Size(88, 46);
            this.LblCikisAgirlik.TabIndex = 33;
            this.LblCikisAgirlik.Text = "....Kg";
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackColor = System.Drawing.Color.Transparent;
            this.BtnExcel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcel.Image")));
            this.BtnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcel.Location = new System.Drawing.Point(829, 6);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(134, 38);
            this.BtnExcel.TabIndex = 6;
            this.BtnExcel.Text = "        Excel\'e Aktar";
            this.BtnExcel.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnTarih
            // 
            this.BtnTarih.BackColor = System.Drawing.Color.Transparent;
            this.BtnTarih.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnTarih.Image = ((System.Drawing.Image)(resources.GetObject("BtnTarih.Image")));
            this.BtnTarih.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTarih.Location = new System.Drawing.Point(173, 39);
            this.BtnTarih.Name = "BtnTarih";
            this.BtnTarih.Size = new System.Drawing.Size(198, 39);
            this.BtnTarih.TabIndex = 3;
            this.BtnTarih.Text = "        Tarihler Arasını Listele";
            this.BtnTarih.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BtnTarih.Click += new System.EventHandler(this.BtnTarih_Click);
            // 
            // FmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 546);
            this.ControlBox = false;
            this.Controls.Add(this.iTalk_ControlBox1);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.LblTarih);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.TapControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmAnaSayfa";
            this.Load += new System.EventHandler(this.FmAnaSayfa_Load);
            this.TapControl.ResumeLayout(false);
            this.TpAnaSayfa.ResumeLayout(false);
            this.TpAnaSayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwAnaSayfaKayit1)).EndInit();
            this.TpAracGiris.ResumeLayout(false);
            this.TpAracGiris.PerformLayout();
            this.TpAracCikis.ResumeLayout(false);
            this.TpAracCikis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwCKayit)).EndInit();
            this.TpRapor.ResumeLayout(false);
            this.TpRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwRKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TapControl;
        private System.Windows.Forms.TabPage TpAnaSayfa;
        private System.Windows.Forms.TabPage TpAracGiris;
        private System.Windows.Forms.TabPage TpAracCikis;
        private System.Windows.Forms.TabPage TpRapor;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MetroFramework.Controls.MetroGrid DgwAnaSayfaKayit1;
        private MaterialSkin.Controls.MaterialLabel LblArac;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox CmbGUrun;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbGGirisAgirlik;
        private System.Windows.Forms.ComboBox CmbGSofor;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbGPlaka;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private iTalk.iTalk_Button_1 BtnGTart;
        private iTalk.iTalk_Button_1 BtnGKayit;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbCSofor;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbCPlaka;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbCUrunAgirlik;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbCCikisAgirlik;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbCGirisAgirlik;
        private System.Windows.Forms.ComboBox CmbCUrun;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MetroFramework.Controls.MetroGrid DgwCKayit;
        private iTalk.iTalk_HeaderLabel LblCikisAgirlik;
        private iTalk.iTalk_Button_1 BtnCKayit;
        private iTalk.iTalk_Button_1 BtnCTart;
        private iTalk.iTalk_HeaderLabel LblTarih;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private MetroFramework.Controls.MetroGrid DgwRKayit;
        private MetroFramework.Controls.MetroDateTime DtTarih1;
        private MetroFramework.Controls.MetroDateTime DtTarih2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbRPlaka;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private iTalk.iTalk_Button_1 BtnTarih;
        private MaterialSkin.Controls.MaterialRaisedButton BtnKapat;
        private iTalk.iTalk_Button_1 BtnExcel;
        private iTalk.iTalk_ControlBox iTalk_ControlBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.ComboBox CmbRSofor;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk.iTalk_HeaderLabel LblGirisAgirlik;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel2;
        private MaterialSkin.Controls.MaterialRadioButton RbRCikisYapanlar;
        private MaterialSkin.Controls.MaterialRadioButton RbRIceridekiAraclar;
        private MaterialSkin.Controls.MaterialRadioButton RbRTumKayitlar;
    }
}