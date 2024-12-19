using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_2_KÜTÜPHANE
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ekleKullanicibtn.Visible = false;
            ekleKitapbtn.Visible = false;
            verKitapbtn.Visible = false;
            listeSilbtn.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(ekleKullanicibtn.Visible ==  false)
            {
                ekleKullanicibtn.Visible = true;
                ekleKitapbtn.Visible = true;
                verKitapbtn.Visible = true;
                listeSilbtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                ekleKitapbtn.Visible = false;
                verKitapbtn.Visible = false;
                listeSilbtn.Visible = false;
            };
            
            
        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciListeForm uyeekle = new KullaniciListeForm();
            uyeekle.ShowDialog();

            KullaniciListeForm klisteform = new KullaniciListeForm();
            klisteform.MdiParent = this;
            klisteform.Show();
        }

        private void ekleKitapbtn_Click(object sender, EventArgs e)
        {
            KitapEkleForm kekleform = new KitapEkleForm();
            kekleform.MdiParent = this;
            kekleform.Show();
        }

        private void verKitapbtn_Click(object sender, EventArgs e)
        {
            KitapVerForm kverform = new KitapVerForm();
            kverform.MdiParent = this;
            kverform.Show();
        }
        private void listeSilbtn_Click(object sender, EventArgs e)
        {

            ÖğrenciListeSil lsilform = new ÖğrenciListeSil();
            lsilform.MdiParent = this;
            lsilform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Mutlu Günler... ");
            Application.Exit();
        }

        
    }
}
