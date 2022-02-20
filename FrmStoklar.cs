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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        YarpuzPansiyonEntities2 db = new YarpuzPansiyonEntities2();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            AlinanUrunler au = new AlinanUrunler();
            au.Cerezler = int.Parse(TxtAtistirmalik.Text);
            au.Gida = int.Parse(TxtGidalar.Text);
            au.Icecek =int.Parse( TxtIcecekler.Text);


            db.AlinanUrunler.Add(au);
            db.SaveChanges();
        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id =0;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            TxtAtistirmalik.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           TxtGidalar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtIcecekler.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();



        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.AlinanUrunler.ToList();
            dataGridView2.DataSource = db.Faturalar.ToList();
        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            Faturalar f = new Faturalar();
            f.Elektrik= int.Parse(TxtElektrik.Text);
            f.Su = int.Parse(TxtElektrik.Text);
            f.Internet = int.Parse(TxtElektrik.Text);


            db.Faturalar.Add(f);
            db.SaveChanges();
        }

        int id2 = 0;
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            id2 = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            TxtElektrik.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtSu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TxtInternet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {

        }
    }
}
