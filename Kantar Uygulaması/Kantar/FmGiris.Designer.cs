namespace Kantar
{
    partial class FmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmGiris));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbKulAdi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TbSifre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CbGosterGizle = new MaterialSkin.Controls.MaterialCheckBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnGiris = new MaterialSkin.Controls.MaterialRaisedButton();
            this.iTalk_ControlBox1 = new iTalk.iTalk_ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TbKulAdi
            // 
            this.TbKulAdi.Depth = 0;
            this.TbKulAdi.Hint = "";
            this.TbKulAdi.Location = new System.Drawing.Point(155, 243);
            this.TbKulAdi.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbKulAdi.Name = "TbKulAdi";
            this.TbKulAdi.PasswordChar = '\0';
            this.TbKulAdi.SelectedText = "";
            this.TbKulAdi.SelectionLength = 0;
            this.TbKulAdi.SelectionStart = 0;
            this.TbKulAdi.Size = new System.Drawing.Size(143, 23);
            this.TbKulAdi.TabIndex = 1;
            this.TbKulAdi.UseSystemPasswordChar = false;
            // 
            // TbSifre
            // 
            this.TbSifre.Depth = 0;
            this.TbSifre.Hint = "";
            this.TbSifre.Location = new System.Drawing.Point(155, 279);
            this.TbSifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbSifre.Name = "TbSifre";
            this.TbSifre.PasswordChar = '\0';
            this.TbSifre.SelectedText = "";
            this.TbSifre.SelectionLength = 0;
            this.TbSifre.SelectionStart = 0;
            this.TbSifre.Size = new System.Drawing.Size(143, 23);
            this.TbSifre.TabIndex = 2;
            this.TbSifre.UseSystemPasswordChar = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 243);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(92, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Kullanıcı Adı";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 283);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Şifre";
            // 
            // CbGosterGizle
            // 
            this.CbGosterGizle.AutoSize = true;
            this.CbGosterGizle.Depth = 0;
            this.CbGosterGizle.Font = new System.Drawing.Font("Roboto", 10F);
            this.CbGosterGizle.Location = new System.Drawing.Point(323, 272);
            this.CbGosterGizle.Margin = new System.Windows.Forms.Padding(0);
            this.CbGosterGizle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CbGosterGizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.CbGosterGizle.Name = "CbGosterGizle";
            this.CbGosterGizle.Ripple = true;
            this.CbGosterGizle.Size = new System.Drawing.Size(71, 30);
            this.CbGosterGizle.TabIndex = 5;
            this.CbGosterGizle.Text = "Göster";
            this.CbGosterGizle.UseVisualStyleBackColor = true;
            this.CbGosterGizle.CheckedChanged += new System.EventHandler(this.CbGosterGizle_CheckedChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ok-icon.png");
            // 
            // BtnGiris
            // 
            this.BtnGiris.Depth = 0;
            this.BtnGiris.ImageList = this.ımageList1;
            this.BtnGiris.Location = new System.Drawing.Point(155, 308);
            this.BtnGiris.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Primary = true;
            this.BtnGiris.Size = new System.Drawing.Size(143, 62);
            this.BtnGiris.TabIndex = 9;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // iTalk_ControlBox1
            // 
            this.iTalk_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iTalk_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ControlBox1.Location = new System.Drawing.Point(333, -1);
            this.iTalk_ControlBox1.Name = "iTalk_ControlBox1";
            this.iTalk_ControlBox1.Size = new System.Drawing.Size(77, 19);
            this.iTalk_ControlBox1.TabIndex = 10;
            this.iTalk_ControlBox1.Text = "iTalk_ControlBox1";
            // 
            // FmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 532);
            this.ControlBox = false;
            this.Controls.Add(this.iTalk_ControlBox1);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.CbGosterGizle);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TbSifre);
            this.Controls.Add(this.TbKulAdi);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmGiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbKulAdi;
        private MaterialSkin.Controls.MaterialSingleLineTextField TbSifre;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox CbGosterGizle;
        private System.Windows.Forms.ImageList ımageList1;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGiris;
        private iTalk.iTalk_ControlBox iTalk_ControlBox1;
    }
}

