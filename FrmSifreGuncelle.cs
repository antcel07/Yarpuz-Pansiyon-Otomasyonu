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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        YarpuzPansiyonEntities2 db = new YarpuzPansiyonEntities2();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            int id3 = 0;
            id3 = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var deger = db.AdminGiris.Find(id3);
            deger.KullaniciAdi = TxtKulAdi.Text;
            deger.Sifre = TxtSifre.Text;
            

          
            db.SaveChanges();
        }

        private void FrmSifreGuncelle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.AdminGiris.ToList();
        }

        int id=0;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            TxtKulAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
