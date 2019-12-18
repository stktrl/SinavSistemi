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
            sayactimer += progressBar1.Maximum - progressBar1.Value +1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            label3.Text = sayac.ToString();
            sayactimer += progressBar1.Maximum - progressBar1.Value + 1;
        }
        
        int sayactimer = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {

           
                sayactimer--;
                progressBar1.Value = sayactimer;
                label2.Text = progressBar1.Value.ToString();


                if (sayactimer == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Süre Doldu.");
                    sayactimer += 15;
                    button1.PerformClick();
                    progressBar1.Value = sayactimer;
                    label2.Text = progressBar1.Value.ToString();
                    timer1.Start();
                }           
        }
        private void Sinavform_Load(object sender, EventArgs e)
        {
            timer1.Start();


            string Soru = "", Resim = "", Asık = "", Bsık = "", Csık = "", Dsık = "", Dogrusık = "";
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-J148P14;Initial Catalog=Sinav;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Soru,Resim,ASıkkı,BSıkkı,CSıkkı,DSıkkı,DogruSık from tbl_Soru order by RAND()", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               
                Soru = dr["Soru"].ToString();
                Resim = dr["Resim"].ToString();
                Asık = dr["ASıkkı"].ToString();
                Bsık = dr["BSıkkı"].ToString();
                Csık = dr["CSıkkı"].ToString();
                Dsık = dr["DSıkkı"].ToString();
                Dogrusık = dr["DogruSık"].ToString();


            }
            dr.Close();
            komut.Dispose();
            baglanti.Close();

            Sinavform f4 = new Sinavform();
            f4.label1.Text = Soru;


        }
    }
}
