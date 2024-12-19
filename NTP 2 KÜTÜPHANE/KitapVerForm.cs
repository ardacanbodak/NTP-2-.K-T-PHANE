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
    public partial class KitapVerForm : Form
    {
        public KitapVerForm()
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
            SqlCommand komut = new SqlCommand("insert into kitapver(kitapadı, kitapyazarı, kişiad, kişisoyad, kişitc, alınantarih) values (@kitapadı,@kitapyazarı,@kişiad,@kişisoyad,@kişitc,@alınantarih)", baglanti);
            komut.Parameters.AddWithValue("@kitapadı", textBox1.Text);
            komut.Parameters.AddWithValue("@kitapyazarı", textBox2.Text);
            komut.Parameters.AddWithValue("@kişiad", textBox3.Text);
            komut.Parameters.AddWithValue("@kişisoyad", textBox4.Text);
            komut.Parameters.AddWithValue("@kişitc", textBox5.Text);
            komut.Parameters.AddWithValue("@alınantarih", textBox6.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap verme başarılı ");
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
    }
}
