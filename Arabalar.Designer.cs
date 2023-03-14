
namespace ArabaKiralama
{
    partial class Arabalar
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
            this.btn_satislar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sehir = new System.Windows.Forms.TextBox();
            this.lbl_arabasayisi = new System.Windows.Forms.Label();
            this.lbl_satisayisi3 = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.dgw_arabalar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_vites = new System.Windows.Forms.TextBox();
            this.pb_araba = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_model2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_renk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_yakit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_kapasite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sehir2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_vites2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_yas = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_sart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_arabalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_satislar
            // 
            this.btn_satislar.BackColor = System.Drawing.Color.LightGray;
            this.btn_satislar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_satislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satislar.ForeColor = System.Drawing.Color.BlueViolet;
            this.btn_satislar.Location = new System.Drawing.Point(214, 13);
            this.btn_satislar.Name = "btn_satislar";
            this.btn_satislar.Size = new System.Drawing.Size(137, 44);
            this.btn_satislar.TabIndex = 19;
            this.btn_satislar.Text = "Satışlar";
            this.btn_satislar.UseVisualStyleBackColor = false;
            this.btn_satislar.Click += new System.EventHandler(this.btn_satislar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(409, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Modele Göre Filtrele";
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_model.Location = new System.Drawing.Point(446, 166);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(173, 38);
            this.txt_model.TabIndex = 17;
            this.txt_model.TextChanged += new System.EventHandler(this.txt_model_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(15, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Şehre Göre Filtrele";
            // 
            // txt_sehir
            // 
            this.txt_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sehir.Location = new System.Drawing.Point(42, 166);
            this.txt_sehir.Name = "txt_sehir";
            this.txt_sehir.Size = new System.Drawing.Size(173, 38);
            this.txt_sehir.TabIndex = 15;
            this.txt_sehir.TextChanged += new System.EventHandler(this.txt_sehir_TextChanged);
            // 
            // lbl_arabasayisi
            // 
            this.lbl_arabasayisi.AutoSize = true;
            this.lbl_arabasayisi.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arabasayisi.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_arabasayisi.Location = new System.Drawing.Point(850, 53);
            this.lbl_arabasayisi.Name = "lbl_arabasayisi";
            this.lbl_arabasayisi.Size = new System.Drawing.Size(74, 29);
            this.lbl_arabasayisi.TabIndex = 14;
            this.lbl_arabasayisi.Text = "label2";
            // 
            // lbl_satisayisi3
            // 
            this.lbl_satisayisi3.AutoSize = true;
            this.lbl_satisayisi3.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_satisayisi3.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_satisayisi3.Location = new System.Drawing.Point(753, 13);
            this.lbl_satisayisi3.Name = "lbl_satisayisi3";
            this.lbl_satisayisi3.Size = new System.Drawing.Size(231, 29);
            this.lbl_satisayisi3.TabIndex = 13;
            this.lbl_satisayisi3.Text = "Toplam Araba Sayısı";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soyad.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_soyad.Location = new System.Drawing.Point(13, 69);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(98, 25);
            this.lbl_soyad.TabIndex = 12;
            this.lbl_soyad.Text = "label2";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_ad.Location = new System.Drawing.Point(13, 13);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(98, 25);
            this.lbl_ad.TabIndex = 11;
            this.lbl_ad.Text = "label1";
            // 
            // dgw_arabalar
            // 
            this.dgw_arabalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_arabalar.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgw_arabalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_arabalar.Location = new System.Drawing.Point(12, 392);
            this.dgw_arabalar.Name = "dgw_arabalar";
            this.dgw_arabalar.RowHeadersWidth = 51;
            this.dgw_arabalar.RowTemplate.Height = 24;
            this.dgw_arabalar.Size = new System.Drawing.Size(986, 211);
            this.dgw_arabalar.TabIndex = 10;
            this.dgw_arabalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_arabalar_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(761, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vites Göre Filtrele";
            // 
            // txt_vites
            // 
            this.txt_vites.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_vites.Location = new System.Drawing.Point(798, 166);
            this.txt_vites.Name = "txt_vites";
            this.txt_vites.Size = new System.Drawing.Size(173, 38);
            this.txt_vites.TabIndex = 20;
            this.txt_vites.TextChanged += new System.EventHandler(this.txt_vites_TextChanged);
            // 
            // pb_araba
            // 
            this.pb_araba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_araba.Location = new System.Drawing.Point(424, 12);
            this.pb_araba.Name = "pb_araba";
            this.pb_araba.Size = new System.Drawing.Size(211, 116);
            this.pb_araba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_araba.TabIndex = 22;
            this.pb_araba.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(9, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Model:";
            // 
            // txt_model2
            // 
            this.txt_model2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_model2.Location = new System.Drawing.Point(162, 226);
            this.txt_model2.Name = "txt_model2";
            this.txt_model2.Size = new System.Drawing.Size(173, 38);
            this.txt_model2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(9, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Renk:";
            // 
            // txt_renk
            // 
            this.txt_renk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_renk.Location = new System.Drawing.Point(162, 275);
            this.txt_renk.Name = "txt_renk";
            this.txt_renk.Size = new System.Drawing.Size(173, 38);
            this.txt_renk.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(9, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Yakıt Türü:";
            // 
            // txt_yakit
            // 
            this.txt_yakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yakit.Location = new System.Drawing.Point(162, 323);
            this.txt_yakit.Name = "txt_yakit";
            this.txt_yakit.Size = new System.Drawing.Size(173, 38);
            this.txt_yakit.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(352, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Kapasite:";
            // 
            // txt_kapasite
            // 
            this.txt_kapasite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kapasite.Location = new System.Drawing.Point(476, 323);
            this.txt_kapasite.Name = "txt_kapasite";
            this.txt_kapasite.Size = new System.Drawing.Size(173, 38);
            this.txt_kapasite.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(357, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "Yaş:";
            // 
            // txt_sehir2
            // 
            this.txt_sehir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sehir2.Location = new System.Drawing.Point(817, 219);
            this.txt_sehir2.Name = "txt_sehir2";
            this.txt_sehir2.Size = new System.Drawing.Size(173, 38);
            this.txt_sehir2.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(352, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Vites:";
            // 
            // txt_vites2
            // 
            this.txt_vites2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_vites2.Location = new System.Drawing.Point(476, 226);
            this.txt_vites2.Name = "txt_vites2";
            this.txt_vites2.Size = new System.Drawing.Size(173, 38);
            this.txt_vites2.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(655, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = "Şehir:";
            // 
            // txt_yas
            // 
            this.txt_yas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yas.Location = new System.Drawing.Point(476, 276);
            this.txt_yas.Name = "txt_yas";
            this.txt_yas.Size = new System.Drawing.Size(173, 38);
            this.txt_yas.TabIndex = 35;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.LightGray;
            this.btn_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.ForeColor = System.Drawing.Color.BlueViolet;
            this.btn_kaydet.Location = new System.Drawing.Point(718, 342);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(137, 44);
            this.btn_kaydet.TabIndex = 37;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(702, 112);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 16);
            this.lbl_id.TabIndex = 38;
            this.lbl_id.Visible = false;
            // 
            // txt_sart
            // 
            this.txt_sart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sart.Location = new System.Drawing.Point(817, 275);
            this.txt_sart.Name = "txt_sart";
            this.txt_sart.Size = new System.Drawing.Size(173, 38);
            this.txt_sart.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(655, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 58);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ehliyet Yaş \r\nŞartı:";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.LightGray;
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.Color.BlueViolet;
            this.btn_sil.Location = new System.Drawing.Point(861, 342);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(137, 44);
            this.btn_sil.TabIndex = 41;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(214, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 44);
            this.button1.TabIndex = 42;
            this.button1.Text = "İstatistikler";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Arabalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1010, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.txt_sart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_yas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_kapasite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_sehir2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_vites2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_yakit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_renk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_model2);
            this.Controls.Add(this.pb_araba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_vites);
            this.Controls.Add(this.btn_satislar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sehir);
            this.Controls.Add(this.lbl_arabasayisi);
            this.Controls.Add(this.lbl_satisayisi3);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.dgw_arabalar);
            this.Name = "Arabalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arabalar";
            this.Load += new System.EventHandler(this.Arabalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_arabalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_satislar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sehir;
        private System.Windows.Forms.Label lbl_arabasayisi;
        private System.Windows.Forms.Label lbl_satisayisi3;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.DataGridView dgw_arabalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_vites;
        private System.Windows.Forms.PictureBox pb_araba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_model2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_renk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_yakit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_kapasite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sehir2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_vites2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_yas;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_sart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button button1;
    }
}