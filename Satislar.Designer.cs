
namespace ArabaKiralama
{
    partial class Satislar
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
            this.dgw_satislar = new System.Windows.Forms.DataGridView();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_satisayisi3 = new System.Windows.Forms.Label();
            this.lbl_satisayisi = new System.Windows.Forms.Label();
            this.txt_sehir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.btn_arabalar = new System.Windows.Forms.Button();
            this.pb_araba = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_satislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_satislar
            // 
            this.dgw_satislar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_satislar.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgw_satislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_satislar.Location = new System.Drawing.Point(12, 227);
            this.dgw_satislar.Name = "dgw_satislar";
            this.dgw_satislar.RowHeadersWidth = 51;
            this.dgw_satislar.RowTemplate.Height = 24;
            this.dgw_satislar.Size = new System.Drawing.Size(776, 211);
            this.dgw_satislar.TabIndex = 0;
            this.dgw_satislar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_satislar_CellClick);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_ad.Location = new System.Drawing.Point(13, 13);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(98, 25);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "label1";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soyad.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_soyad.Location = new System.Drawing.Point(13, 69);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(98, 25);
            this.lbl_soyad.TabIndex = 2;
            this.lbl_soyad.Text = "label2";
            // 
            // lbl_satisayisi3
            // 
            this.lbl_satisayisi3.AutoSize = true;
            this.lbl_satisayisi3.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_satisayisi3.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_satisayisi3.Location = new System.Drawing.Point(548, 13);
            this.lbl_satisayisi3.Name = "lbl_satisayisi3";
            this.lbl_satisayisi3.Size = new System.Drawing.Size(226, 29);
            this.lbl_satisayisi3.TabIndex = 3;
            this.lbl_satisayisi3.Text = "Toplam Satış Sayısı";
            // 
            // lbl_satisayisi
            // 
            this.lbl_satisayisi.AutoSize = true;
            this.lbl_satisayisi.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_satisayisi.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_satisayisi.Location = new System.Drawing.Point(645, 53);
            this.lbl_satisayisi.Name = "lbl_satisayisi";
            this.lbl_satisayisi.Size = new System.Drawing.Size(74, 29);
            this.lbl_satisayisi.TabIndex = 4;
            this.lbl_satisayisi.Text = "label2";
            // 
            // txt_sehir
            // 
            this.txt_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sehir.Location = new System.Drawing.Point(65, 167);
            this.txt_sehir.Name = "txt_sehir";
            this.txt_sehir.Size = new System.Drawing.Size(173, 38);
            this.txt_sehir.TabIndex = 5;
            this.txt_sehir.TextChanged += new System.EventHandler(this.txt_sehir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(38, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şehre Göre Filtrele";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(543, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modele Göre Filtrele";
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_model.Location = new System.Drawing.Point(580, 167);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(173, 38);
            this.txt_model.TabIndex = 7;
            this.txt_model.TextChanged += new System.EventHandler(this.txt_model_TextChanged);
            // 
            // btn_arabalar
            // 
            this.btn_arabalar.BackColor = System.Drawing.Color.LightGray;
            this.btn_arabalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_arabalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_arabalar.ForeColor = System.Drawing.Color.BlueViolet;
            this.btn_arabalar.Location = new System.Drawing.Point(178, 53);
            this.btn_arabalar.Name = "btn_arabalar";
            this.btn_arabalar.Size = new System.Drawing.Size(137, 44);
            this.btn_arabalar.TabIndex = 9;
            this.btn_arabalar.Text = "Arabalar";
            this.btn_arabalar.UseVisualStyleBackColor = false;
            this.btn_arabalar.Click += new System.EventHandler(this.btn_arabalar_Click);
            // 
            // pb_araba
            // 
            this.pb_araba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_araba.Location = new System.Drawing.Point(331, 14);
            this.pb_araba.Name = "pb_araba";
            this.pb_araba.Size = new System.Drawing.Size(211, 116);
            this.pb_araba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_araba.TabIndex = 23;
            this.pb_araba.TabStop = false;
            // 
            // Satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_araba);
            this.Controls.Add(this.btn_arabalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sehir);
            this.Controls.Add(this.lbl_satisayisi);
            this.Controls.Add(this.lbl_satisayisi3);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.dgw_satislar);
            this.Name = "Satislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satislar";
            this.Load += new System.EventHandler(this.Satislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_satislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_satislar;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_satisayisi3;
        private System.Windows.Forms.Label lbl_satisayisi;
        private System.Windows.Forms.TextBox txt_sehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Button btn_arabalar;
        private System.Windows.Forms.PictureBox pb_araba;
    }
}