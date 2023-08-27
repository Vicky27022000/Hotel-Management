using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmenu.Items.Clear(); //for all this not see in city
            if (cmbtype.Text == "Maharashtrian")
            {
                cmbmenu.Items.Add("Misal Pav");
                cmbmenu.Items.Add("Puran Poli");
                cmbmenu.Items.Add("Vada pav");
            }
            if (cmbtype.Text == "Gujrati")
            {
                cmbmenu.Items.Add("Dhokla");
                cmbmenu.Items.Add("Fafda");
                cmbmenu.Items.Add("Khichdi");
            }
            if (cmbtype.Text == "Panjabi")
            {
                cmbmenu.Items.Add("Paratha");
                cmbmenu.Items.Add("Pakoda");
                cmbmenu.Items.Add("Palak Paneer");
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = cmbtype.Text;
            string value1 = cmbmenu.Text;
            string value2 = cmbprice.Text;
           Order objmn= new Order(value, value1, value2);
            
            objmn.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {


        }

        private void cmbmenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbmenu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbprice.Items.Clear();
            if (cmbmenu.Text=="Misal Pav")
            {
                cmbprice.Items.Add(38);
            }
          if (cmbmenu.Text=="Puran Poli")
            {
                cmbprice.Items.Add(150);
            }
          if(  cmbmenu.Text== "Vada pav")
                {
                cmbprice.Items.Add(25);
            }
        
              if(  cmbmenu.Text=="Dhokla")
            {
                cmbprice.Items.Add(47);
            }
              if(  cmbmenu.Text=="Fafda")
            {
                cmbprice.Items.Add(70);
            }
              if(  cmbmenu.Text=="Khichdi")
            {
                cmbprice.Items.Add(80);
            }
            
             if(   cmbmenu.Text=="Paratha")
            {
                cmbprice.Items.Add(40);
            }
             if(   cmbmenu.Text=="Pakoda")
            {
                cmbprice.Items.Add(45);
            }
              if(  cmbmenu.Text=="Palak Paneer")
            {
                cmbprice.Items.Add(65);
            }
        }
    }
}
