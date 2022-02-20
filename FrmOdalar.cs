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
           
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        YarpuzPansiyonEntities2 db = new YarpuzPansiyonEntities2();
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            Btn101.Text = db.Oda101.Select(x => x.Adi + " " + x.Soyadi).FirstOrDefault();
            if(Btn101.Text!="101" && Btn101.Text!="")
            {
               
                Btn101.BackColor = Color.Red;
            }
            else
            {
                Btn101.Text = "101";
            }

            Btn102.Text = db.Oda102.Select(x1 => x1.Adi + " " + x1.Soyadi).FirstOrDefault();
            if (Btn102.Text != "102" && Btn102.Text !="")
            {
                
                Btn102.BackColor = Color.Red;
            }
            else
            {
                Btn102.Text = "102";
            }
            

             Btn103.Text = db.Oda103.Select(x3 => x3.Adi + " " + x3.Soyadi).FirstOrDefault();
            if (Btn103.Text != "103" && Btn103.Text != "")
            {
               
                Btn103.BackColor = Color.Red;
            }
            else
            {
                Btn103.Text = "103";
            }

            Btn104.Text = db.Oda104.Select(x4 => x4.Adi + " " + x4.Soyadi).FirstOrDefault();
            if (Btn104.Text != "104" && Btn104.Text != "")
            {
               
                Btn104.BackColor = Color.Red;
            }
            else
            {
                Btn104.Text = "104";
            }

            Btn105.Text = db.Oda105.Select(x5 => x5.Adi + " " + x5.Soyadi).FirstOrDefault();
            if (Btn105.Text != "105" && Btn105.Text != "")
            {
                
                Btn105.BackColor = Color.Red;
            }
            else
            {
                Btn105.Text = "105";
            }

            Btn106.Text = db.Oda106.Select(x6 => x6.Adi + " " + x6.Soyadi).FirstOrDefault();
            if (Btn106.Text != "106" && Btn106.Text != "")
            { 
               

                Btn106.BackColor = Color.Red;
            }
            else
            {
                Btn106.Text = "106";
            }



            Btn107.Text = db.Oda107.Select(x7 => x7.Adi + " " + x7.Soyadi).FirstOrDefault();
             if (Btn107.Text != "107" && Btn107.Text != "")
            {
                
                Btn107.BackColor = Color.Red;
            }
            else
            {
                Btn107.Text = "107";
            }



            Btn108.Text = db.Oda108.Select(x8 => x8.Adi + " " + x8.Soyadi).FirstOrDefault();
            if (Btn108.Text != "108" && Btn108.Text != "")
            {
               
                Btn108.BackColor = Color.Red;
            }

            else
            {
                Btn108.Text = "108";
            }

            Btn109.Text = db.Oda109.Select(x9 => x9.Adi + " " + x9.Soyadi).FirstOrDefault();
            if (Btn109.Text != "109" && Btn109.Text != "")
            {
               
                Btn109.BackColor = Color.Red;
            }
            else
            {
                Btn109.Text = "109";
            }
        }

        private void Btn101_Click(object sender, EventArgs e)
        {
          
                

           // LblToplamDepartman.Text = db.TblDepartmanlar.Count().ToString();
        }

        private void Btn102_Click(object sender, EventArgs e)
        {

        }
    }
}
