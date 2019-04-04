using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Connect c = new Connect();
        public SqlConnection con;
        public SqlCommand cd;
        public SqlDataReader dr;

        private void Form6_Load(object sender, EventArgs e) // loading staff view form.
        {
            addcombo();
        }


        public void addcombo()               // for autocompleting item in the search box.
        {


            c.getconn();
            string q = "select * from staff";
            c.save(q);
            c.readata(q);

            try
            {
                while (c.dr.Read())
                {
                    if (c.dr.HasRows == true)
                    {
                        
                        comboBox1.Items.Add(c.dr[0]);
                    }


                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show("ex", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

           
          
      


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  // go button.
        {
            Connect d = new Connect();
            d.getconn();

            string w = "select * from staff where Fname= '" + comboBox1.Text + "'";
            d.readata(w);

            while (d.dr.Read())
            {
                label19.Text = d.dr[0].ToString();
                label20.Text = d.dr[1].ToString();
                label21.Text = d.dr[2].ToString();
                label22.Text = d.dr[3].ToString();
                label23.Text = d.dr[4].ToString();
                label24.Text = d.dr[5].ToString();
                label25.Text = d.dr[6].ToString();
                label26.Text = d.dr[7].ToString();
                label27.Text = d.dr[10].ToString();
                label28.Text = d.dr[14].ToString();
                label29.Text = d.dr[15].ToString();
                label30.Text = d.dr[11].ToString();
                label31.Text = d.dr[13].ToString();
                label32.Text = d.dr[12].ToString();
                textBox16.Text = d.dr[8].ToString();
                textBox15.Text = d.dr[9].ToString();
                pictureBox1.ImageLocation = d.dr[16].ToString();
                d.dr.Close();


            }

            d.dr.Close();
            d.con.Close();





        }

      
        
    }
}
