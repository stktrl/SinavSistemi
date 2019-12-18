using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSis
{
    public partial class OgretmenForm : Form
    {
        public OgretmenForm()
        {
            InitializeComponent();
        }

        private void OgretmenForm_Load(object sender, EventArgs e)
        {
            soruEkle1.Visible = false;
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            AnaMenu f1 = new AnaMenu();
            this.Hide();
            f1.Show();
        }

        private void buton2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buton2.Height;
            SidePanel.Top = buton2.Top;
            soruEkle1.Visible = true;
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buton1.Height;
            SidePanel.Top = buton1.Top;
            soruEkle1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
            Application.Exit();
        }
    }
}
