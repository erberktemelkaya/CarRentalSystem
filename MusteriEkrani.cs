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
    public partial class MusteriEkrani : Form
    {
        public MusteriEkrani()
        {
            InitializeComponent();
        }

        ArabaKiralamaEntities db = new ArabaKiralamaEntities();

        public string Tc;
        public int id, araba_id;

        private void MusteriEkrani_Load(object sender, EventArgs e)
        {
            foreach (var musteri in db.Tbl_Musteri)
            {
                if (musteri.Musteri_TC == Tc)
                {
                    id = musteri.Musteri_ID;
                    txt_adsoyad.Text = musteri.Musteri_AdSoyad;
                    txt_dogumtarihi.Text = Convert.ToString(musteri.Musteri_DogumTarihi);
                    txt_ehliyetyil.Text = Convert.ToString(musteri.Musteri_EhliyetAlmaTarihi);
                    txt_email.Text = musteri.Musteri_Email;
                    txt_sehir.Text = musteri.Musteri_Sehir;
                    txt_tc.Text = musteri.Musteri_TC;
                    txt_telefon.Text = musteri.Musteri_TelNo;
                }
            }

            this.Text = txt_adsoyad.Text;
            ReadOnlyAyarlama();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var musteri = db.Tbl_Musteri.Find(id);
            if (musteri.Musteri_AdSoyad == null)
            {
                musteri.Musteri_AdSoyad = txt_adsoyad.Text;
                musteri.Musteri_TC = txt_tc.Text;
                musteri.Musteri_DogumTarihi = Convert.ToDateTime(txt_dogumtarihi.Text);
                musteri.Musteri_EhliyetAlmaTarihi = Convert.ToDateTime(txt_ehliyetyil.Text);
            }
            musteri.Musteri_Email = txt_email.Text;
            musteri.Musteri_TelNo = txt_telefon.Text;
            musteri.Musteri_Sehir = txt_sehir.Text;
            db.SaveChanges();
            ReadOnlyAyarlama();
            MessageBox.Show("Başarıyla Kaydedildi.", "Helal Aslanım Benim", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Text = txt_adsoyad.Text;
        }

        private void radio_araba_CheckedChanged(object sender, EventArgs e)
        {
            arabaDurumAyarla();
            var musteri1 = db.Tbl_Musteri.Find(id);
            dgw_tablo.DataSource = db.Tbl_Araba.Where(p => p.Araba_Sehir.ToLower() == musteri1.Musteri_Sehir.ToLower() && p.Araba_Durum == true).ToList();
            dgw_tablo.Columns["Araba_Id"].Visible = false;
            dgw_tablo.Columns["Araba_Durum"].Visible = false;
            dgw_tablo.Columns["Tbl_Satis"].Visible = false;
            dgw_tablo.Columns["Araba_Foto"].Visible = false;
            date_alis.Value = DateTime.Now;
            date_teslim.Value = DateTime.Now;
        }

        private void radio_satis_CheckedChanged(object sender, EventArgs e)
        {
            arabaDurumAyarla();
            var tablo = from itemsatis in db.Tbl_Satis
                        join itemaraba in db.Tbl_Araba
                        on itemsatis.Araba_ID equals itemaraba.Araba_ID
                        join itemmusteri in db.Tbl_Musteri
                        on itemsatis.Musteri_ID equals itemmusteri.Musteri_ID
                        where itemmusteri.Musteri_ID == id
                        select new
                        {
                            Araba_Id = itemaraba.Araba_ID,
                            MüşteriAdSoyad = itemmusteri.Musteri_AdSoyad,
                            ArabaModel = itemaraba.Araba_Model,
                            Şehir = itemmusteri.Musteri_Sehir,
                            AlışTarihi = itemsatis.Satis_AlisTarihi,
                            TeslimTarihi = itemsatis.Satis_TeslimTarihi
                        };
            dgw_tablo.DataSource = tablo.ToList();
            dgw_tablo.Columns["Araba_Id"].Visible = false;
        }

        private void dgw_tablo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgw_tablo.ColumnCount == 12)
            {
                string adres = Convert.ToString(dgw_tablo.CurrentRow.Cells[10].Value);
                pb_araba.ImageLocation = adres;
                araba_id = Convert.ToInt32(dgw_tablo.CurrentRow.Cells[0].Value);
            }
            if (dgw_tablo.ColumnCount == 6)
            {
                araba_id = Convert.ToInt32(dgw_tablo.CurrentRow.Cells[0].Value);
                var araba = db.Tbl_Araba.Find(araba_id);
                string adres = araba.Araba_Foto;
                pb_araba.ImageLocation = adres;
                date_alis.Value = Convert.ToDateTime(dgw_tablo.CurrentRow.Cells[4].Value);
                date_teslim.Value = Convert.ToDateTime(dgw_tablo.CurrentRow.Cells[5].Value);
            }
        }

        private void btn_kirala_Click(object sender, EventArgs e)
        {
            if (date_alis.Value < DateTime.Now && date_alis.Value < date_teslim.Value && date_teslim.Value>DateTime.Now)
            {
                Tbl_Satis satis = new Tbl_Satis()
                {
                    Satis_AlisTarihi = Convert.ToDateTime(date_alis.Value),
                    Satis_TeslimTarihi = Convert.ToDateTime(date_teslim.Value),
                    Araba_ID = araba_id,
                    Musteri_ID = id
                };
                db.Tbl_Satis.Add(satis);
                db.SaveChanges();
                arabaDurumAyarla();
                radio_satis_CheckedChanged(sender, e);
                MessageBox.Show("Araba Başarıyla Kiralandı.", "Helal Aslan Kardeşim Benim", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arabaDurumAyarla()
        {
            var tablo = from itemsatis in db.Tbl_Satis
                        join itemaraba in db.Tbl_Araba
                        on itemsatis.Araba_ID equals itemaraba.Araba_ID
                        select new
                        {
                            Araba_Id = itemaraba.Araba_ID,
                            AlışTarihi = itemsatis.Satis_AlisTarihi,
                            TeslimTarihi = itemsatis.Satis_TeslimTarihi
                        };

            foreach (var satis in tablo)
            {
                if (satis.AlışTarihi < DateTime.Now && satis.TeslimTarihi > DateTime.Now)
                {
                    var araba = db.Tbl_Araba.Find(satis.Araba_Id);
                    araba.Araba_Durum = false;
                }
            }
            db.SaveChanges();
        }

        private void ReadOnlyAyarlama()
        {
            var musteri = db.Tbl_Musteri.Find(id);
            if (musteri.Musteri_AdSoyad == null)
            {
                txt_adsoyad.ReadOnly = false;
                txt_tc.ReadOnly = false;
                txt_dogumtarihi.ReadOnly = false;
                txt_ehliyetyil.ReadOnly = false;
            }
            else
            {
                txt_adsoyad.ReadOnly = true;
                txt_tc.ReadOnly = true;
                txt_dogumtarihi.ReadOnly = true;
                txt_ehliyetyil.ReadOnly = true;
            }
        }

    }
}
