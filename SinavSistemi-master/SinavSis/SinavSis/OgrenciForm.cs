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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
            SidePanel.Height = buton1.Height;
            SidePanel.Top = buton1.Top;
            istatikler1.Visible = false;

        }
      
        private void OgrenciForm_Load(object sender, EventArgs e)
        {

        }
            
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buton1.Height;
            SidePanel.Top = buton1.Top;
            label1.Visible = false;
            button2.Visible = false;
            istatikler1.Visible = false;


        }

        private void buton2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buton2.Height;
            SidePanel.Top = buton2.Top;
            label1.Visible = true;
            button2.Visible = true;
            istatikler1.Visible = false;
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buton3.Height;
            SidePanel.Top = buton3.Top;
            label1.Visible = false;
            button2.Visible = false;
            istatikler1.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AnaMenu f1 = new AnaMenu();
            this.Hide();
            f1.Show();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-C9KDPNN;Initial Catalog='Yazılım test proje';Integrated Security=True");
            baglanti.Open();
            Test test = new Test();
            SqlCommand komut = new SqlCommand("Select * from istatistik where ogrenciNo=@ogrenciNo ORDER BY sinavTarihi DESC ", baglanti);
            komut.Parameters.AddWithValue("@ogrenciNo", kullaniciBilgisi.kullaniciNo);
            
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                test.oncekiSinavTarihi = Convert.ToDateTime(dr["sinavTarihi"]);
                if (test.oncekiSinavTarihi.Date == DateTime.Now.Date)
                {
                    MessageBox.Show("Bu gün sınav oldun. Yarın tekrar gel.");
                    break;
                }
                else
                {
                     Sinavform f3 = new Sinavform();
                     kullaniciBilgisi.sonSinavTarihi = test.oncekiSinavTarihi;
                     f3.Show();
                     this.Hide();
                    break;

                }


            }
            if (test.oncekiSinavTarihi == DateTime.MinValue)
            {
                Sinavform f3 = new Sinavform();
                kullaniciBilgisi.sonSinavTarihi = test.oncekiSinavTarihi;
                f3.Show();
                this.Hide();

            }

            
            
                
            

            dr.Close();
            komut.Dispose();
            baglanti.Close();
           
            
        }
    }
}
