using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NTP_2_KÜTÜPHANE
{
    public partial class KullaniciListeForm : Form
    {


        public KullaniciListeForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form aaa = new Form();
            aaa.Show();
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BATUSELINPELIN\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye(tc,ad,soyad,telefon,adres) values (@tc,@ad,@soyad,@telefon,@adres)", baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@telefon", textBox4.Text);
            komut.Parameters.AddWithValue("@adres", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Yapıldı ");

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void KullaniciListeForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                        this.Close();

        }
    }
}
