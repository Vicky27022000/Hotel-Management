using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home objhm=new Home();
            objhm.MdiParent = this;
            objhm.Show();           
            objhm.Top= 0;
            

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu Objmenu = new Menu();
            Objmenu.MdiParent = this;
            Objmenu.Show();
            Objmenu.Left= 0;
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
