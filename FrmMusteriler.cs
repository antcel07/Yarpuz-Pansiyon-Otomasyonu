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

    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        YarpuzPansiyonEntities2 db = new YarpuzPansiyonEntities2();
        void Listele()
        {


            dataGridView1.DataSource = db.MusteriEkle.ToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //id göre silme yaptık datagrid seçilen ıd

            int id = 0;
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var deger = db.MusteriEkle.Find(id);

            db.MusteriEkle.Remove(deger);
            db.SaveChanges();




            if (TxtOdaNo.Text=="101")
            {
                var sil = db.Oda101.Where(x => x.Adi == TxtAdi.Text).FirstOrDefault();
                db.Oda101.Remove(sil);
                db.SaveChanges();
            }

            if (TxtOdaNo.Text == "102")
            {


                var sil = db.Oda102.Where(x => x.Adi == TxtAdi.Text).FirstOrDefault();
                db.Oda102.Remove(sil);
                db.SaveChanges();
            }

            if (TxtOdaNo.Text == "103")
            {
                var sil = db.Oda103.Where(x => x.Adi == TxtAdi.Text).FirstOrDefault();
                db.Oda103.Remove(sil);
                db.SaveChanges();

            }
            if (TxtOdaNo.Text == "104")
            {
                var sil = db.Oda104.Where(x => x.Adi == TxtAdi.Text).FirstOrDefault();
                db.Oda104.Remove(sil);
                db.SaveChanges();
            }
            if (TxtOdaNo.Text == "105")
            {
                var sil = db.Oda105.Where(x => x.Adi == TxtAdi.Text).FirstOrDefault();
                db.Oda105.Remove(sil);
                db.SaveChanges();
            }

            if (TxtOdaNo.Text == "106")
            {
                var sil = db.Oda106.Where(x => x.Adi == TxtAdi.Text).FirstOrDefault();
                db.Oda106.Remove(sil);
                db.SaveChanges();
            }
            if (TxtOdaNo.Text == "107")
            {
                var sil = db.Oda107.Where(x => x.Adi == TxtAdi.Text).FirstOrDefault();
                db.Oda107.Remove(sil);
                db.SaveChanges();
            }

            if (TxtOdaNo.Text == "108")
            {
                var sil = db.Oda108.Where(x => x.Adi == TxtAdi.Text).FirstOrDefault();
                db.Oda108.Remove(sil);
                db.SaveChanges();
            }

            if (TxtOdaNo.Text == "109")
            {
                var sil = db.Oda109.Where(x => x.Adi == TxtAdi.Text).FirstOrDefault();
                db.Oda109.Remove(sil);
                db.SaveChanges();
            }

       



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
          int id = 0;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id=int.Parse (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            TxtAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           MskTextTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            TxtMail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TxtTcNo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            TxtOdaNo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            TxtUcret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            DtpGirisTarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            DtpCikisTarihi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }
      
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTextTelefon.Clear();
            TxtMail.Clear();
            TxtTcNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //id3 göre veriyi seçeriz yaptık ıd sayesinde gelir sonrada güncelleme işlemini yaparız.
            int id3 = 0;
            id3 = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var deger = db.MusteriEkle.Find(id3);
            deger.Adi = TxtAdi.Text;
           deger.Soyadi = TxtSoyadi.Text;
            deger.Cinsiyet = comboBox1.Text;
            deger.Telefon = MskTextTelefon.Text;
            deger.Mail = TxtMail.Text;
            deger.TC = TxtTcNo.Text;
            deger.OdaNo = TxtOdaNo.Text;
            deger.Ucret = int.Parse(TxtUcret.Text);

            deger.GirisTarihi = DateTime.Parse(DtpGirisTarihi.Value.ToString("yyyy-MM-dd"));
            deger.CikisTarihi = DateTime.Parse(DtpCikisTarihi.Value.ToString("yyyy-MM-dd"));
            db.SaveChanges();

        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            var gelen = textBox1.Text;
            dataGridView1.DataSource = db.MusteriEkle.Where(x => x.Adi.Contains(gelen)).ToList();
           
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
    }
    }

