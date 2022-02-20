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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            YarpuzPansiyonEntities2 db = new YarpuzPansiyonEntities2();

            var giris = (db.AdminGiris.Where(x => x.KullaniciAdi == TxtKulAdi.Text && x.Sifre == TxtSifre.Text).FirstOrDefault());
            {
                if (giris == null)

                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");

                }
                else
                {
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.Show();
                    this.Hide();
                }
            }

           
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
