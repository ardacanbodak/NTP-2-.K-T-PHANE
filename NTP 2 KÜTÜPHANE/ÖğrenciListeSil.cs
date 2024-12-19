using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_2_KÜTÜPHANE
{
    public partial class ÖğrenciListeSil : Form
    {
        public ÖğrenciListeSil()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BATUSELINPELIN\\SQLEXPRESS;Initial Catalog=Kutuphane;Integrated Security=True");

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from uye where tc like '"+textBox6.Text+"' ", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textBox2.Text = read["ad"].ToString();
                textBox3.Text = read["soyad"].ToString();
                textBox4.Text = read["telefon"].ToString();
                textBox5.Text = read["adres"].ToString();

            }
            baglanti.Close();
        }
        DataSet daset = new DataSet(); // Kayıtları geçiçi olarak tutacağımız bir tablo 
        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            daset.Tables["uye"].Clear(); // Kayıtların üst üste binmemesi için
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter ("select * from uye where tc like '%" +textBox6.Text+ "%'", baglanti);
            adtr.Fill(daset,"uye"); 
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();
         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from uye where tc=@tc", baglanti); //Parametre kullanacağımız için @tc yazdık
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleşti.");
            daset.Tables["uye"].Clear();
            uyelistele();
            foreach(Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void uyelistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from uye", baglanti);
            adtr.Fill(daset,"uye");
            dataGridView1.DataSource = daset.Tables["uye"];
            baglanti.Close();

        }
        private void ÖğrenciListeSil_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update uye set ad=@ad, soyad=@soyad, telefon=@telefon, adres=@adres where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc", textBox1.Text);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@soyad", textBox3.Text);
            komut.Parameters.AddWithValue("@telefon", textBox4.Text);
            komut.Parameters.AddWithValue("@adres", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti.");
            daset.Tables["uye"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form aaa = new Form();
            aaa.Show();
            this.Hide();
        }
    }
}
