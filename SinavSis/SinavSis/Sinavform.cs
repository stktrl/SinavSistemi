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

namespace SinavSis
{
    public partial class Sinavform : Form
    {
        public Sinavform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaMenu f1 = new AnaMenu();
            f1.Show();
            this.Hide();
        }
        int sayac = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            label3.Text = sayac.ToString();
            

            if (radioButton1.Checked)
            {
                if (radioButton1.Text == Dogrusık.ToString());
                MessageBox.Show("Doğru");
            }
            if (radioButton2.Checked)
            {
                if (radioButton2.Text == Dogrusık.ToString()) ;
                MessageBox.Show("Yanlış");
            }
            if (radioButton3.Checked)
            {
                if (radioButton3.Text == Dogrusık.ToString()) ;
                MessageBox.Show("Yanlış");
            }
            if (radioButton4.Checked)
            {
                if (radioButton4.Text == Dogrusık.ToString()) ;
                MessageBox.Show("Yanlış");
            }


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            label3.Text = sayac.ToString();
            
        }

        int dakika = 60;
        int saniye = 60;
        int sayactimer=3600;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayactimer -= 1;
            saniye -= 1;
            labelsaniye.Text = saniye.ToString();
            labeldakika.Text = (dakika - 1).ToString();
            if (saniye == 0)
            {
                dakika = dakika - 1;
                labeldakika.Text = dakika.ToString();
                saniye = 60;
            }
            if (labeldakika.Text=="-1" || sayactimer == 0)
            {
                timer1.Stop();
                labeldakika.Text = "00";
                labelsaniye.Text = "00";
                MessageBox.Show("Süreniz BİTTİ. Anamenüye yönlendiriliyorsunuz.");
                button3.PerformClick();


            }
            progressBar1.Value = sayactimer;             
                         
        }
        string Dogrusık = "";
        private void Sinavform_Load(object sender, EventArgs e)
        {
            timer1.Start();

            
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J148P14;Initial Catalog=Sinav;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TOP 5 Soru,ASıkkı,BSıkkı,CSıkkı,DSıkkı,DogruCevap,Resim from tbl_Soru order by newid()", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               
                label1.Text = dr["Soru"].ToString();
               
                radioButton1.Text = dr["ASıkkı"].ToString();
                radioButton2.Text = dr["BSıkkı"].ToString();
                radioButton3.Text = dr["CSıkkı"].ToString();
                radioButton4.Text = dr["DSıkkı"].ToString();
                Dogrusık = dr["DogruCevap"].ToString();
                pictureBox1.ImageLocation = dr["Resim"].ToString();


            }
            dr.Close();
            komut.Dispose();
            baglanti.Close();

            
        



        }

      
    }
}
