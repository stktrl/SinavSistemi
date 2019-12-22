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
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J148P14;Initial Catalog=Sinav;Integrated Security=True");

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
            textBox4sık.Text = openFileDialog2.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_Soru(Ders,Soru,Resim,ASıkkı,BSıkkı,CSıkkı,DSıkkı,DogruCevap) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            komut.Parameters.AddWithValue("@p1", TextBoxDers.Text);           
            komut.Parameters.AddWithValue("@p3", TextBoxSoru.Text);
            komut.Parameters.AddWithValue("@p4", TextBoxResim.Text);
            komut.Parameters.AddWithValue("@p5", textBox1sık.Text);
            komut.Parameters.AddWithValue("@p6", textBox2sık.Text);
            komut.Parameters.AddWithValue("@p7", textBox3sık.Text);
            komut.Parameters.AddWithValue("@p8", textBox4sık.Text);
            komut.Parameters.AddWithValue("@p9", textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
        }

        private void SoruEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
