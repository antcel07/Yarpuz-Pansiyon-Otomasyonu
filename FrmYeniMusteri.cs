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
    
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            Oda101 o = new Oda101();
            o.Adi = TxtAdi.Text;
            o.Soyadi = TxtSoyadi.Text;
            db.Oda101.Add(o);
            db.SaveChanges();
            MessageBox.Show("Yeni Müsteri Kaydı Başarılı Şekilde Gerçekleşti");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Btn102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            Oda102 o = new Oda102();
            o.Adi = TxtAdi.Text;
            o.Soyadi = TxtSoyadi.Text;
            db.Oda102.Add(o);
            db.SaveChanges();
          
        }

        private void Btn103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            Oda103 o = new Oda103();
            o.Adi = TxtAdi.Text;
            o.Soyadi = TxtSoyadi.Text;
            db.Oda103.Add(o);
            db.SaveChanges();
        }

        private void Btn104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            Oda104 o= new Oda104();
            o.Adi = TxtAdi.Text;
            o.Soyadi = TxtSoyadi.Text;
            db.Oda104.Add(o);
            db.SaveChanges();
        }

        private void Btn105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            Oda105 o = new Oda105();
            o.Adi = TxtAdi.Text;
            o.Soyadi = TxtSoyadi.Text;
            db.Oda105.Add(o);
            db.SaveChanges();
        }

        private void Btn106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            Oda106 o = new Oda106();
            o.Adi = TxtAdi.Text;
            o.Soyadi = TxtSoyadi.Text;
            db.Oda106.Add(o);
            db.SaveChanges();
        }

        private void Btn107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            Oda107 o = new Oda107();
            o.Adi = TxtAdi.Text;
            o.Soyadi = TxtSoyadi.Text;
            db.Oda107.Add(o);
            db.SaveChanges();
        }

        private void Btn108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            Oda108 o = new Oda108();
            o.Adi = TxtAdi.Text;
            o.Soyadi = TxtSoyadi.Text;
            db.Oda108.Add(o);
            db.SaveChanges();
        }

        private void Btn109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            Oda109 o = new Oda109();
            o.Adi = TxtAdi.Text;
            o.Soyadi = TxtSoyadi.Text;
            db.Oda109.Add(o);
            db.SaveChanges();
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Temsil Eder.");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Temsil Eder.");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int hesap;
            DateTime kTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime bTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan snc = bTarih - kTarih;

            label11.Text = snc.TotalDays.ToString();

            hesap = Convert.ToInt32(label11.Text) * 50;
            TxtUcret.Text = hesap.ToString();
        }

        YarpuzPansiyonEntities2 db = new YarpuzPansiyonEntities2();
        private void button1_Click(object sender, EventArgs e)
        {
            MusteriEkle m = new MusteriEkle();
            m.Adi = TxtAdi.Text;
            m.Soyadi = TxtSoyadi.Text;
            m.Cinsiyet = comboBox1.Text;
            m.Telefon = MskTextTelefon.Text;
            m.Mail = TxtMail.Text;
            m.TC = TxtTcNo.Text;
            m.OdaNo = TxtOdaNo.Text;
            m.Ucret = int.Parse(TxtUcret.Text);
         
            m.GirisTarihi = DateTime.Parse(DtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
            m.CikisTarihi = DateTime.Parse(DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
          

            db.MusteriEkle.Add(m);
            db.SaveChanges();
            MessageBox.Show("Yeni Müsteri Kaydı Başarılı Şekilde Gerçekleşti");
            }
        

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            Btn101.Text = db.Oda101.Select(x => x.Adi + " " + x.Soyadi).FirstOrDefault();
            if (Btn101.Text != "101" && Btn101.Text != "")
            {

                Btn101.BackColor = Color.Red;
                Btn101.Enabled = false;
            }
            else
            {
                Btn101.Text = "101";
            }

            Btn102.Text = db.Oda102.Select(x1 => x1.Adi + " " + x1.Soyadi).FirstOrDefault();
            if (Btn102.Text != "102" && Btn102.Text != "")
            {

                Btn102.BackColor = Color.Red;
                Btn102.Enabled = false;
            }
            else
            {
                Btn102.Text = "102";
            }


            Btn103.Text = db.Oda103.Select(x3 => x3.Adi + " " + x3.Soyadi).FirstOrDefault();
            if (Btn103.Text != "103" && Btn103.Text != "")
            {

                Btn103.BackColor = Color.Red;
                Btn103.Enabled = false;
            }
            else
            {
                Btn103.Text = "103";
            }

            Btn104.Text = db.Oda104.Select(x4 => x4.Adi + " " + x4.Soyadi).FirstOrDefault();
            if (Btn104.Text != "104" && Btn104.Text != "")
            {

                Btn104.BackColor = Color.Red;
                Btn104.Enabled = false;
            }
            else
            {
                Btn104.Text = "104";
            }

            Btn105.Text = db.Oda105.Select(x5 => x5.Adi + " " + x5.Soyadi).FirstOrDefault();
            if (Btn105.Text != "105" && Btn105.Text != "")
            {

                Btn105.BackColor = Color.Red;
                Btn105.Enabled = false;
            }
            else
            {
                Btn105.Text = "105";
            }

            Btn106.Text = db.Oda106.Select(x6 => x6.Adi + " " + x6.Soyadi).FirstOrDefault();
            if (Btn106.Text != "106" && Btn106.Text != "")
            {


                Btn106.BackColor = Color.Red;
                Btn106.Enabled = false;
            }
            else
            {
                Btn106.Text = "106";
            }



            Btn107.Text = db.Oda107.Select(x7 => x7.Adi + " " + x7.Soyadi).FirstOrDefault();
            if (Btn107.Text != "107" && Btn107.Text != "")
            {

                Btn107.BackColor = Color.Red;
                Btn107.Enabled = false;
            }
            else
            {
                Btn107.Text = "107";
            }



            Btn108.Text = db.Oda108.Select(x8 => x8.Adi + " " + x8.Soyadi).FirstOrDefault();
            if (Btn108.Text != "108" && Btn108.Text != "")
            {

                Btn108.BackColor = Color.Red;
                Btn108.Enabled = false;
            }

            else
            {
                Btn108.Text = "108";
            }

            Btn109.Text = db.Oda109.Select(x9 => x9.Adi + " " + x9.Soyadi).FirstOrDefault();
            if (Btn109.Text != "109" && Btn109.Text != "")
            {

                Btn109.BackColor = Color.Red;
                Btn109.Enabled = false;
            }
            else
            {
                Btn109.Text = "109";
            }
        }
    }
}
