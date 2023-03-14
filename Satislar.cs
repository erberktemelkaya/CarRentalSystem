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
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }

        public string isim, soyisim;

        ArabaKiralamaEntities db = new ArabaKiralamaEntities();

        private void txt_sehir_TextChanged(object sender, EventArgs e)
        {
            var x = (from itemsatis in db.Tbl_Satis
                     join itemaraba in db.Tbl_Araba
                     on itemsatis.Araba_ID equals itemaraba.Araba_ID
                     join itemmusteri in db.Tbl_Musteri
                     on itemsatis.Musteri_ID equals itemmusteri.Musteri_ID
                     select new
                     {
                         MüşteriAdSoyad = itemmusteri.Musteri_AdSoyad,
                         ArabaModel = itemaraba.Araba_Model,
                         Şehir = itemmusteri.Musteri_Sehir,
                         AlışTarihi = itemsatis.Satis_AlisTarihi,
                         TeslimTarihi = itemsatis.Satis_TeslimTarihi
                     }).ToList();
            dgw_satislar.DataSource = x.Where(p => p.Şehir.ToLower().Contains(txt_sehir.Text)).ToList();
        }

        private void btn_arabalar_Click(object sender, EventArgs e)
        {
            Arabalar arabalar = new Arabalar();
            arabalar.isim = this.isim;
            arabalar.soyisim = this.soyisim;
            arabalar.Show();
            this.Hide();
        }

        private void txt_model_TextChanged(object sender, EventArgs e)
        {
            var x = (from itemsatis in db.Tbl_Satis
                     join itemaraba in db.Tbl_Araba
                     on itemsatis.Araba_ID equals itemaraba.Araba_ID
                     join itemmusteri in db.Tbl_Musteri
                     on itemsatis.Musteri_ID equals itemmusteri.Musteri_ID
                     select new
                     {
                         MüşteriAdSoyad = itemmusteri.Musteri_AdSoyad,
                         ArabaModel = itemaraba.Araba_Model,
                         Şehir = itemmusteri.Musteri_Sehir,
                         AlışTarihi = itemsatis.Satis_AlisTarihi,
                         TeslimTarihi = itemsatis.Satis_TeslimTarihi,
                     }).ToList();
            dgw_satislar.DataSource = x.ToList().Where(p => p.ArabaModel.ToLower().Contains(txt_model.Text)).ToList();
        }

        private void dgw_satislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string adres = dgw_satislar.CurrentRow.Cells[5].Value.ToString();
            pb_araba.ImageLocation = adres;
        }

        private void Satislar_Load(object sender, EventArgs e)
        {
            var x = from itemsatis in db.Tbl_Satis
                    join itemaraba in db.Tbl_Araba
                    on itemsatis.Araba_ID equals itemaraba.Araba_ID
                    join itemmusteri in db.Tbl_Musteri
                    on itemsatis.Musteri_ID equals itemmusteri.Musteri_ID
                    select new
                    {
                        MüşteriAdSoyad = itemmusteri.Musteri_AdSoyad,
                        ArabaModel = itemaraba.Araba_Model,
                        Şehir = itemmusteri.Musteri_Sehir,
                        AlışTarihi = itemsatis.Satis_AlisTarihi,
                        TeslimTarihi = itemsatis.Satis_TeslimTarihi,
                        Araba_Foto = itemaraba.Araba_Foto
                    };

            lbl_ad.Text = isim;
            lbl_soyad.Text = soyisim;
            dgw_satislar.DataSource = x.ToList();
            lbl_satisayisi.Text = db.Tbl_Satis.Count().ToString();
            dgw_satislar.Columns["Araba_Foto"].Visible = false;
        }
    }
}
