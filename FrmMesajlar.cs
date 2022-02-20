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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        YarpuzPansiyonEntities2 db = new YarpuzPansiyonEntities2();
        private void button1_Click(object sender, EventArgs e)
        {


            Mesajlar msj= new Mesajlar();
            msj.AdSoyad = TxtAdSoy.Text;
            msj.Mesaj = TxtMesaj.Text;
            


            db.Mesajlar.Add(msj);
            db.SaveChanges();
            dataGridView1.DataSource = db.Mesajlar.ToList();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Mesajlar.ToList();
        }

        int id2 = 0;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id2 = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            TxtAdSoy.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtMesaj.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //id3 göre veriyi seçeriz yaptık ıd sayesinde gelir sonrada güncelleme işlemini yaparız.
            int id3 = 0;
            id3 = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var deger = db.Mesajlar.Find(id3);
            deger.AdSoyad = TxtAdSoy.Text;
            deger.Mesaj = TxtMesaj.Text;
            

            
            db.SaveChanges();
        }
    }
}
