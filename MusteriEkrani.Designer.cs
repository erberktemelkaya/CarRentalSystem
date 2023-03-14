
namespace ArabaKiralama
{
    partial class MusteriEkrani
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
            this.dgw_tablo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_adsoyad = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_sehir = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_ehliyetyil = new System.Windows.Forms.TextBox();
            this.txt_dogumtarihi = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.pb_araba = new System.Windows.Forms.PictureBox();
            this.radio_araba = new System.Windows.Forms.RadioButton();
            this.radio_satis = new System.Windows.Forms.RadioButton();
            this.date_alis = new System.Windows.Forms.DateTimePicker();
            this.date_teslim = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_kirala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_tablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_tablo
            // 
            this.dgw_tablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_tablo.Location = new System.Drawing.Point(12, 461);
            this.dgw_tablo.Name = "dgw_tablo";
            this.dgw_tablo.RowHeadersWidth = 51;
            this.dgw_tablo.RowTemplate.Height = 24;
            this.dgw_tablo.Size = new System.Drawing.Size(1053, 150);
            this.dgw_tablo.TabIndex = 0;
            this.dgw_tablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_tablo_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(130, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(8, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(61, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(483, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(376, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ehliyet Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(483, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şehir:";
            // 
            // txt_adsoyad
            // 
            this.txt_adsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adsoyad.Location = new System.Drawing.Point(184, 24);
            this.txt_adsoyad.Name = "txt_adsoyad";
            this.txt_adsoyad.ReadOnly = true;
            this.txt_adsoyad.Size = new System.Drawing.Size(179, 30);
            this.txt_adsoyad.TabIndex = 10;
            // 
            // txt_tc
            // 
            this.txt_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tc.Location = new System.Drawing.Point(184, 96);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.ReadOnly = true;
            this.txt_tc.Size = new System.Drawing.Size(179, 30);
            this.txt_tc.TabIndex = 11;
            // 
            // txt_telefon
            // 
            this.txt_telefon.BackColor = System.Drawing.SystemColors.Control;
            this.txt_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telefon.Location = new System.Drawing.Point(184, 175);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(179, 30);
            this.txt_telefon.TabIndex = 13;
            // 
            // txt_sehir
            // 
            this.txt_sehir.BackColor = System.Drawing.SystemColors.Control;
            this.txt_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sehir.Location = new System.Drawing.Point(585, 96);
            this.txt_sehir.Name = "txt_sehir";
            this.txt_sehir.Size = new System.Drawing.Size(179, 30);
            this.txt_sehir.TabIndex = 16;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Control;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.Location = new System.Drawing.Point(585, 24);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(179, 30);
            this.txt_email.TabIndex = 14;
            // 
            // txt_ehliyetyil
            // 
            this.txt_ehliyetyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ehliyetyil.Location = new System.Drawing.Point(585, 172);
            this.txt_ehliyetyil.Name = "txt_ehliyetyil";
            this.txt_ehliyetyil.ReadOnly = true;
            this.txt_ehliyetyil.Size = new System.Drawing.Size(179, 30);
            this.txt_ehliyetyil.TabIndex = 15;
            // 
            // txt_dogumtarihi
            // 
            this.txt_dogumtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_dogumtarihi.Location = new System.Drawing.Point(184, 241);
            this.txt_dogumtarihi.Name = "txt_dogumtarihi";
            this.txt_dogumtarihi.ReadOnly = true;
            this.txt_dogumtarihi.Size = new System.Drawing.Size(179, 30);
            this.txt_dogumtarihi.TabIndex = 12;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kaydet.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_kaydet.Location = new System.Drawing.Point(582, 231);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(138, 38);
            this.btn_kaydet.TabIndex = 17;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // pb_araba
            // 
            this.pb_araba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_araba.Location = new System.Drawing.Point(812, 21);
            this.pb_araba.Name = "pb_araba";
            this.pb_araba.Size = new System.Drawing.Size(253, 184);
            this.pb_araba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_araba.TabIndex = 18;
            this.pb_araba.TabStop = false;
            // 
            // radio_araba
            // 
            this.radio_araba.AutoSize = true;
            this.radio_araba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_araba.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_araba.ForeColor = System.Drawing.Color.Purple;
            this.radio_araba.Location = new System.Drawing.Point(12, 412);
            this.radio_araba.Name = "radio_araba";
            this.radio_araba.Size = new System.Drawing.Size(191, 30);
            this.radio_araba.TabIndex = 19;
            this.radio_araba.TabStop = true;
            this.radio_araba.Text = "Araba Getir";
            this.radio_araba.UseVisualStyleBackColor = true;
            this.radio_araba.CheckedChanged += new System.EventHandler(this.radio_araba_CheckedChanged);
            // 
            // radio_satis
            // 
            this.radio_satis.AutoSize = true;
            this.radio_satis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_satis.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_satis.ForeColor = System.Drawing.Color.Purple;
            this.radio_satis.Location = new System.Drawing.Point(231, 412);
            this.radio_satis.Name = "radio_satis";
            this.radio_satis.Size = new System.Drawing.Size(322, 30);
            this.radio_satis.TabIndex = 20;
            this.radio_satis.TabStop = true;
            this.radio_satis.Text = "Kiralama Geçmişi Getir";
            this.radio_satis.UseVisualStyleBackColor = true;
            this.radio_satis.CheckedChanged += new System.EventHandler(this.radio_satis_CheckedChanged);
            // 
            // date_alis
            // 
            this.date_alis.CalendarForeColor = System.Drawing.Color.Wheat;
            this.date_alis.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.date_alis.CalendarTitleForeColor = System.Drawing.Color.Wheat;
            this.date_alis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_alis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_alis.Location = new System.Drawing.Point(894, 318);
            this.date_alis.MinDate = new System.DateTime(2023, 1, 4, 0, 0, 0, 0);
            this.date_alis.Name = "date_alis";
            this.date_alis.Size = new System.Drawing.Size(145, 30);
            this.date_alis.TabIndex = 21;
            // 
            // date_teslim
            // 
            this.date_teslim.CalendarForeColor = System.Drawing.Color.Wheat;
            this.date_teslim.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.date_teslim.CalendarTitleForeColor = System.Drawing.Color.Wheat;
            this.date_teslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_teslim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_teslim.Location = new System.Drawing.Point(894, 360);
            this.date_teslim.MinDate = new System.DateTime(2023, 1, 4, 0, 0, 0, 0);
            this.date_teslim.Name = "date_teslim";
            this.date_teslim.Size = new System.Drawing.Size(145, 30);
            this.date_teslim.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(697, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Teslim Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(731, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 26);
            this.label9.TabIndex = 23;
            this.label9.Text = "Alış Tarihi:";
            // 
            // btn_kirala
            // 
            this.btn_kirala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kirala.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kirala.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_kirala.Location = new System.Drawing.Point(843, 409);
            this.btn_kirala.Name = "btn_kirala";
            this.btn_kirala.Size = new System.Drawing.Size(138, 38);
            this.btn_kirala.TabIndex = 25;
            this.btn_kirala.Text = "Kirala";
            this.btn_kirala.UseVisualStyleBackColor = true;
            this.btn_kirala.Click += new System.EventHandler(this.btn_kirala_Click);
            // 
            // MusteriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 623);
            this.Controls.Add(this.btn_kirala);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.date_teslim);
            this.Controls.Add(this.date_alis);
            this.Controls.Add(this.radio_satis);
            this.Controls.Add(this.radio_araba);
            this.Controls.Add(this.pb_araba);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_sehir);
            this.Controls.Add(this.txt_ehliyetyil);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_dogumtarihi);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.txt_adsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_tablo);
            this.Name = "MusteriEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriEkrani";
            this.Load += new System.EventHandler(this.MusteriEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_tablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_tablo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_adsoyad;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_sehir;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_ehliyetyil;
        private System.Windows.Forms.TextBox txt_dogumtarihi;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.PictureBox pb_araba;
        private System.Windows.Forms.RadioButton radio_araba;
        private System.Windows.Forms.RadioButton radio_satis;
        private System.Windows.Forms.DateTimePicker date_alis;
        private System.Windows.Forms.DateTimePicker date_teslim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_kirala;
    }
}