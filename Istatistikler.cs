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
    public partial class Istatistikler : Form
    {
        public Istatistikler()
        {
            InitializeComponent();
        }

        ArabaKiralamaEntities db = new ArabaKiralamaEntities();

        private void Istatistikler_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> sehirler = new Dictionary<string, int>();

            foreach (var araba in db.Tbl_Araba)
            {
                if (!sehirler.Keys.Contains(araba.Araba_Sehir))
                {
                    sehirler.Add(araba.Araba_Sehir, 1);
                }
                else
                {
                    sehirler[araba.Araba_Sehir]++;
                }
            }

            foreach (KeyValuePair<string, int> entry in sehirler)
            {
                chart_araba.Series["Şehir"].Points.AddXY(entry.Key, entry.Value);
            }
        }

    }
}
