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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text.Trim();
            string gelenSifre = sifreGiristxt.Text;

            if(gelenAd.Equals("admin") && gelenSifre.Equals("admin"))
            {
                MessageBox.Show("Başarili");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi veya sifre hatali");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sifreGiristxt.UseSystemPasswordChar = false;
            }
            else
                sifreGiristxt.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
