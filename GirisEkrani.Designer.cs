
namespace ArabaKiralama
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.pbMusteri = new System.Windows.Forms.PictureBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_adminsifre = new System.Windows.Forms.Label();
            this.lbl_adminkullaniciadi = new System.Windows.Forms.Label();
            this.txt_adminsifre = new System.Windows.Forms.TextBox();
            this.txt_adminkullaniciadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_musteri = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.btn_x = new System.Windows.Forms.Button();
            this.radio_yeni = new System.Windows.Forms.RadioButton();
            this.radio_var = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMusteri
            // 
            this.pbMusteri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMusteri.Image = ((System.Drawing.Image)(resources.GetObject("pbMusteri.Image")));
            this.pbMusteri.Location = new System.Drawing.Point(141, 100);
            this.pbMusteri.Name = "pbMusteri";
            this.pbMusteri.Size = new System.Drawing.Size(199, 148);
            this.pbMusteri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMusteri.TabIndex = 0;
            this.pbMusteri.TabStop = false;
            this.pbMusteri.Click += new System.EventHandler(this.pbMusteri_Click);
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_mail.Location = new System.Drawing.Point(211, 300);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(199, 38);
            this.txt_mail.TabIndex = 2;
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.Location = new System.Drawing.Point(211, 343);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(199, 38);
            this.txt_tc.TabIndex = 3;
            this.txt_tc.UseSystemPasswordChar = true;
            this.txt_tc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tc_KeyDown);
            // 
            // pbAdmin
            // 
            this.pbAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbAdmin.Image")));
            this.pbAdmin.Location = new System.Drawing.Point(587, 100);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(199, 148);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdmin.TabIndex = 4;
            this.pbAdmin.TabStop = false;
            this.pbAdmin.Click += new System.EventHandler(this.pbAdmin_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.Crimson;
            this.btn_giris.Location = new System.Drawing.Point(364, 395);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(166, 44);
            this.btn_giris.TabIndex = 7;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mail.Location = new System.Drawing.Point(13, 303);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(163, 32);
            this.lbl_mail.TabIndex = 8;
            this.lbl_mail.Text = "Mail Adresi:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc.Location = new System.Drawing.Point(13, 346);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(187, 32);
            this.lbl_tc.TabIndex = 9;
            this.lbl_tc.Text = "TC Numarası:";
            // 
            // lbl_adminsifre
            // 
            this.lbl_adminsifre.AutoSize = true;
            this.lbl_adminsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adminsifre.Location = new System.Drawing.Point(424, 346);
            this.lbl_adminsifre.Name = "lbl_adminsifre";
            this.lbl_adminsifre.Size = new System.Drawing.Size(81, 32);
            this.lbl_adminsifre.TabIndex = 13;
            this.lbl_adminsifre.Text = "Şifre:";
            // 
            // lbl_adminkullaniciadi
            // 
            this.lbl_adminkullaniciadi.AutoSize = true;
            this.lbl_adminkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adminkullaniciadi.Location = new System.Drawing.Point(424, 303);
            this.lbl_adminkullaniciadi.Name = "lbl_adminkullaniciadi";
            this.lbl_adminkullaniciadi.Size = new System.Drawing.Size(180, 32);
            this.lbl_adminkullaniciadi.TabIndex = 12;
            this.lbl_adminkullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // txt_adminsifre
            // 
            this.txt_adminsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adminsifre.Location = new System.Drawing.Point(608, 343);
            this.txt_adminsifre.Name = "txt_adminsifre";
            this.txt_adminsifre.Size = new System.Drawing.Size(199, 38);
            this.txt_adminsifre.TabIndex = 11;
            this.txt_adminsifre.UseSystemPasswordChar = true;
            this.txt_adminsifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_adminsifre_KeyDown);
            // 
            // txt_adminkullaniciadi
            // 
            this.txt_adminkullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adminkullaniciadi.Location = new System.Drawing.Point(608, 300);
            this.txt_adminkullaniciadi.Name = "txt_adminkullaniciadi";
            this.txt_adminkullaniciadi.Size = new System.Drawing.Size(199, 38);
            this.txt_adminkullaniciadi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(181, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Müşteri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(635, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(184, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(543, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giriş Yapmak İçin Resimlere Tıklayınız!";
            // 
            // lbl_musteri
            // 
            this.lbl_musteri.AutoSize = true;
            this.lbl_musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_musteri.ForeColor = System.Drawing.Color.Purple;
            this.lbl_musteri.Location = new System.Drawing.Point(180, 261);
            this.lbl_musteri.Name = "lbl_musteri";
            this.lbl_musteri.Size = new System.Drawing.Size(120, 20);
            this.lbl_musteri.TabIndex = 17;
            this.lbl_musteri.Text = "Müşteri Seçildi";
            this.lbl_musteri.Visible = false;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_admin.ForeColor = System.Drawing.Color.Purple;
            this.lbl_admin.Location = new System.Drawing.Point(637, 261);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(111, 20);
            this.lbl_admin.TabIndex = 18;
            this.lbl_admin.Text = "Admin Seçildi";
            this.lbl_admin.Visible = false;
            // 
            // btn_x
            // 
            this.btn_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_x.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x.ForeColor = System.Drawing.Color.Red;
            this.btn_x.Location = new System.Drawing.Point(848, 9);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(50, 50);
            this.btn_x.TabIndex = 19;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.btn_x_click);
            // 
            // radio_yeni
            // 
            this.radio_yeni.AutoSize = true;
            this.radio_yeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_yeni.ForeColor = System.Drawing.Color.DarkGreen;
            this.radio_yeni.Location = new System.Drawing.Point(190, 395);
            this.radio_yeni.Name = "radio_yeni";
            this.radio_yeni.Size = new System.Drawing.Size(121, 29);
            this.radio_yeni.TabIndex = 20;
            this.radio_yeni.TabStop = true;
            this.radio_yeni.Text = "Yeni Kayıt";
            this.radio_yeni.UseVisualStyleBackColor = true;
            this.radio_yeni.CheckedChanged += new System.EventHandler(this.radio_yeni_CheckedChanged);
            // 
            // radio_var
            // 
            this.radio_var.AutoSize = true;
            this.radio_var.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_var.ForeColor = System.Drawing.Color.DarkGreen;
            this.radio_var.Location = new System.Drawing.Point(19, 395);
            this.radio_var.Name = "radio_var";
            this.radio_var.Size = new System.Drawing.Size(146, 29);
            this.radio_var.TabIndex = 21;
            this.radio_var.TabStop = true;
            this.radio_var.Text = "Hesabım Var";
            this.radio_var.UseVisualStyleBackColor = true;
            this.radio_var.CheckedChanged += new System.EventHandler(this.radio_var_CheckedChanged);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(910, 463);
            this.Controls.Add(this.radio_var);
            this.Controls.Add(this.radio_yeni);
            this.Controls.Add(this.btn_x);
            this.Controls.Add(this.lbl_admin);
            this.Controls.Add(this.lbl_musteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_adminsifre);
            this.Controls.Add(this.lbl_adminkullaniciadi);
            this.Controls.Add(this.txt_adminsifre);
            this.Controls.Add(this.txt_adminkullaniciadi);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.pbAdmin);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.pbMusteri);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pbMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMusteri;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_adminsifre;
        private System.Windows.Forms.Label lbl_adminkullaniciadi;
        private System.Windows.Forms.TextBox txt_adminsifre;
        private System.Windows.Forms.TextBox txt_adminkullaniciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_musteri;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.RadioButton radio_yeni;
        private System.Windows.Forms.RadioButton radio_var;
    }
}