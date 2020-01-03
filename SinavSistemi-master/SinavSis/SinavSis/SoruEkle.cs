using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinavSis
{
    public partial class SoruEkle : UserControl
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-C9KDPNN;Initial Catalog='Yazılım test proje';Integrated Security=True");

        public SoruEkle()
        {
            InitializeComponent();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog2.FileName;
            TextBoxResim.Text = openFileDialog2.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog2.FileName;
            textBox1sık.Text = openFileDialog2.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog2.FileName;
            textBox2sık.Text = openFileDialog2.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog2.FileName;
            textBox3sık.Text = openFileDialog2.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog2.FileName;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Sorular (Soru,dogru,yanlis1,yanlis2,yanlis3,baslikId,resim) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            
            komut.Parameters.AddWithValue("@p1", TextBoxSoru.Text);
            komut.Parameters.AddWithValue("@p7", TextBoxResim.Text);
            komut.Parameters.AddWithValue("@p3", textBox1sık.Text);
            komut.Parameters.AddWithValue("@p4", textBox2sık.Text);
            komut.Parameters.AddWithValue("@p5", textBox3sık.Text);
            komut.Parameters.AddWithValue("@p2", textBox1.Text);
            switch (comboBox1.Text)
            {
                case "Bölünebilme Kuralları":
                    komut.Parameters.AddWithValue("@p6", 1);
                    break;
                case "Mod":
                    komut.Parameters.AddWithValue("@p6", 2);
                    break;
                case "Bir Bilinmeyenli Denklem":
                    komut.Parameters.AddWithValue("@p6", 3);
                    break;
                case "Mantık":
                    komut.Parameters.AddWithValue("@p6", 4);
                    break;
                case "Çarpanlara Ayırma":
                    komut.Parameters.AddWithValue("@p6", 5);
                    break;

            }
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
        }

        private void SoruEkle_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
