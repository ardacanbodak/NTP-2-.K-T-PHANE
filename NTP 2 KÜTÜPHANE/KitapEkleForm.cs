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
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
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
            SqlCommand komut = new SqlCommand("insert into kitapekle(ad, yazar, sayfa, yayınevi, tür) values (@ad,@yazar,@sayfa,@yayınevi,@tür)", baglanti);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@yazar", textBox2.Text);
            komut.Parameters.AddWithValue("@sayfa", textBox3.Text);
            komut.Parameters.AddWithValue("@yayınevi", textBox4.Text);
            komut.Parameters.AddWithValue("@tür", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap ekleme başarılı ");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KitapEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
