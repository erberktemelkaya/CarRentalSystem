using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaKiralama
{
    public partial class Arabalar : Form
    {
        public Arabalar()
        {
            InitializeComponent();
        }

        public string isim, soyisim;

        ArabaKiralamaEntities db = new ArabaKiralamaEntities();

        private void txt_sehir_TextChanged(object sender, EventArgs e)
        {
            dgw_arabalar.DataSource = db.Tbl_Araba.Where(p => p.Araba_Sehir.ToLower().Contains(txt_sehir.Text)).ToList();
        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {
            dgw_arabalar.DataSource = db.Tbl_Araba.Where(p => p.Araba_Model.ToLower().Contains(txt_model.Text)).ToList();
        }

        private void txt_vites_TextChanged(object sender, EventArgs e)
        {
            dgw_arabalar.DataSource = db.Tbl_Araba.Where(p => p.Araba_VitesTuru.ToLower().Contains(txt_vites.Text)).ToList();
        }

        private void btn_satislar_Click(object sender, EventArgs e)
        {
            Satislar satislar = new Satislar();
            satislar.isim = this.isim;
            satislar.soyisim = this.soyisim;
            satislar.Show();
            this.Hide();
        }

        private void dgw_arabalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgw_arabalar.CurrentRow.Cells[10].Value!=null)
            {
                string adres = dgw_arabalar.CurrentRow.Cells[10].Value.ToString();
                pb_araba.ImageLocation = adres;
            }

            lbl_id.Text=dgw_arabalar.CurrentRow.Cells[0].Value.ToString();
            txt_model2.Text = dgw_arabalar.CurrentRow.Cells[1].Value.ToString();
            txt_renk.Text=dgw_arabalar.CurrentRow.Cells[2].Value.ToString();
            txt_yakit.Text= dgw_arabalar.CurrentRow.Cells[3].Value.ToString();
            txt_vites2.Text=dgw_arabalar.CurrentRow.Cells[4].Value.ToString();
            txt_yas.Text = dgw_arabalar.CurrentRow.Cells[5].Value.ToString();
            txt_kapasite.Text = dgw_arabalar.CurrentRow.Cells[6].Value.ToString();
            txt_sart.Text = dgw_arabalar.CurrentRow.Cells[7].Value.ToString();
            txt_sehir2.Text = dgw_arabalar.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_id.Text))
            {
                Tbl_Araba araba = new Tbl_Araba()
                {
                    Araba_Model = txt_model2.Text,
                    Araba_Renk = txt_renk.Text,
                    Araba_YakitTuru = txt_yakit.Text,
                    Araba_VitesTuru = txt_vites2.Text,
                    Araba_Yas = Convert.ToByte(txt_yas.Text),
                    Araba_Kapasite = Convert.ToByte(txt_kapasite.Text),
                    Araba_EhliyetYasSarti = Convert.ToByte(txt_sart.Text),
                    Araba_Sehir = txt_sehir2.Text,
                    Araba_Durum = true
                };

                db.Tbl_Araba.Add(araba);
                db.SaveChanges();
                Temizle();
                MessageBox.Show("Başarıyla Eklendi.", "Helal Aslan Parçası", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            if (!string.IsNullOrEmpty(lbl_id.Text))
            {
                var car = db.Tbl_Araba.Find(Convert.ToInt32(lbl_id.Text));
                car.Araba_Model = txt_model2.Text;
                car.Araba_Renk = txt_renk.Text;
                car.Araba_YakitTuru = txt_yakit.Text;
                car.Araba_VitesTuru = txt_vites2.Text;
                car.Araba_Yas = Convert.ToByte(txt_yas.Text);
                car.Araba_Kapasite = Convert.ToByte(txt_kapasite.Text);
                car.Araba_EhliyetYasSarti = Convert.ToByte(txt_sart.Text);
                car.Araba_Sehir = txt_sehir2.Text;
                db.SaveChanges();
                Temizle();
                MessageBox.Show("Başarıyla Güncellendi.", "Helal Aslan Parçası", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void TabloyaAktar()
        {
            dgw_arabalar.DataSource = db.Tbl_Araba.ToList();
            dgw_arabalar.Columns["Araba_Id"].Visible = false;
            dgw_arabalar.Columns["Araba_Durum"].Visible = false;
            dgw_arabalar.Columns["Tbl_Satis"].Visible = false;
            dgw_arabalar.Columns["Araba_Foto"].Visible = false;
        }

        private void Arabalar_Load(object sender, EventArgs e)
        {
            TabloyaAktar();
            lbl_ad.Text = isim;
            lbl_soyad.Text = soyisim;
            lbl_arabasayisi.Text = db.Tbl_Araba.Count().ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_id.Text))
            {
                var car = db.Tbl_Araba.Find(Convert.ToInt32(lbl_id.Text));
                db.Tbl_Araba.Remove(car);
                db.SaveChanges();
                Temizle();
                MessageBox.Show("Başarıyla Silindi.", "Helal Aslan Parçası", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Istatistikler istatistikler = new Istatistikler();
            istatistikler.Show();
            this.Hide();
        }

        private void Temizle()
        {
            lbl_id.Text = null;
            txt_model2.Clear();
            txt_renk.Clear();
            txt_yakit.Clear();
            txt_vites2.Clear();
            txt_yas.Clear();
            txt_kapasite.Clear();
            txt_sart.Clear();
            txt_sehir2.Clear();
            pb_araba.Image = null;
            pb_araba.Update();
            TabloyaAktar();
        }
    }
}
