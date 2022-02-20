using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yarpuz_Pansiyon_Uygulama.Entity;

namespace Yarpuz_Pansiyon_Uygulama
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        YarpuzPansiyonEntities2 db = new YarpuzPansiyonEntities2();
        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            LblKasadaTopTutar.Text = db.MusteriEkle.Sum(x => x.Ucret).ToString();
            LblAlinanUrun.Text = db.AlinanUrunler.Sum(x => x.Icecek).ToString();
            LblAlinanUrun2.Text = db.AlinanUrunler.Sum(x => x.Gida).ToString();
            LblAlinanUrun3.Text = db.AlinanUrunler.Sum(x => x.Cerezler).ToString();
            LblFaturalar.Text = db.Faturalar.Sum(x => x.Elektrik).ToString();
            LblFaturalar2.Text = db.Faturalar.Sum(x => x.Su).ToString();
            LblFaturalar3.Text = db.Faturalar.Sum(x => x.Internet).ToString();

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            LblPerMaas.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasadaTopTutar.Text) - (Convert.ToInt32(LblPerMaas.Text)+ Convert.ToInt32( LblAlinanUrun.Text)+ Convert.ToInt32( LblAlinanUrun2.Text)+ Convert.ToInt32(LblAlinanUrun3.Text)+ Convert.ToInt32(LblFaturalar.Text)+ Convert.ToInt32(LblFaturalar2.Text)+ Convert.ToInt32( LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();
        }
    }
}
