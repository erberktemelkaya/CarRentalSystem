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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private bool yeniKayit = false;

        ArabaKiralamaEntities db = new ArabaKiralamaEntities();

        public bool statu = true;

        private void pbMusteri_Click(object sender, EventArgs e)
        {
            statu = true;
            lbl_musteri.Visible = true;
            lbl_admin.Visible = false;
        }

        private void pbAdmin_Click(object sender, EventArgs e)
        {
            statu = false;
            lbl_musteri.Visible = false;
            lbl_admin.Visible = true;
        }

        private void txt_tc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_giris.PerformClick();
            }
        }

        private void txt_adminsifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_giris.PerformClick();
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (statu == false)
            {
                bool varmi = false;
                varmi = db.Tbl_Admin.Where(x => x.Admin_KullaniciAdi == txt_adminkullaniciadi.Text && x.Admin_Sifre == txt_adminsifre.Text).Any();
                if (varmi == true)
                {
                    Satislar satislar = new Satislar();
                    if (txt_adminkullaniciadi.Text == "ebo")
                    {
                        satislar.isim = "Erberk";
                        satislar.soyisim = "Temelkaya";
                    }
                    if (txt_adminkullaniciadi.Text == "eren")
                    {
                        satislar.isim = "Ahmet Eren";
                        satislar.soyisim = "Selvi";
                    }
                    satislar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Bilgilerinizi Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bool varmi = false;
                varmi = db.Tbl_Musteri.Where(p => p.Musteri_Email == txt_mail.Text && p.Musteri_TC == txt_tc.Text).Any();
                if (varmi == true && yeniKayit == false)
                {
                    MusteriEkrani musteriEkrani = new MusteriEkrani();
                    musteriEkrani.Tc = txt_tc.Text;
                    musteriEkrani.Show();
                    this.Hide();
                }
                else if (varmi == false && yeniKayit == true)
                {
                    if (txt_tc.Text.Length == 11 && txt_mail.Text.Contains("@")&txt_mail.Text.EndsWith(".com"))
                    {
                        kayitEkle();
                        MusteriEkrani musteriEkrani = new MusteriEkrani();
                        musteriEkrani.Tc = txt_tc.Text;
                        musteriEkrani.Show();
                        this.Hide();
                    }
                    else if (txt_tc.Text.Length!=11)
                    {
                        MessageBox.Show("TC 11 Haneli Olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!txt_mail.Text.Contains("@"))
                    {
                        MessageBox.Show("Geçersiz Mail Adresi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Giriş Bilgilerinizi Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_x_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kayitEkle()
        {
            if (!(db.Tbl_Musteri.Where(p => p.Musteri_TC == txt_tc.Text).Any()))
            {
                Tbl_Musteri musteri = new Tbl_Musteri();
                musteri.Musteri_TC = txt_tc.Text;
                musteri.Musteri_Email = txt_mail.Text;
                db.Tbl_Musteri.Add(musteri);
                db.SaveChanges();
            }
        }

        private void radio_yeni_CheckedChanged(object sender, EventArgs e)
        {
            yeniKayit = true;
        }

        private void radio_var_CheckedChanged(object sender, EventArgs e)
        {
            yeniKayit = false;
        }

    }
}
