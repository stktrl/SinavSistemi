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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
            SidePanel.Height = buton1.Height;
            SidePanel.Top = buton1.Top;
            

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
            
            
        }

        private void buton2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buton2.Height;
            SidePanel.Top = buton2.Top;
            label1.Visible = true;
            button2.Visible = true;
           
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = buton3.Height;
            SidePanel.Top = buton3.Top;
            label1.Visible = false;
            button2.Visible = false;

        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AnaMenu f1 = new AnaMenu();
            this.Hide();
            f1.Show();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            Sinavform f3 = new Sinavform();
            f3.Show();
            this.Hide();
            
        }
    }
}
