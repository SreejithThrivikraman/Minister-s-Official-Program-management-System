using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class offstafreg : Form
    {
        public offstafreg()
        {
            InitializeComponent();
        }

        public Connect c = new Connect();
        
        
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


        private void offstafreg_Load(object sender, EventArgs e)    // form loading event

        {
            addcombo();
        }

        ////private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        ////{
        ////    con = new SqlConnection(@"Data Source=sree-PC;Initial Catalog=Office;User ID=sa;Password=s");
        ////    con.Open();

        ////    string w = "select * from appo where aname= '" + comboBox2.Text + "'";
        ////    cd = new SqlCommand(w, con);
        ////    dr = cd.ExecuteReader();

        ////    while (dr.Read())
        ////    {
        ////        textBox1.Text = dr[0].ToString();
        ////        comboBox1.Text = dr[1].ToString();
        ////        textBox2.Text = dr[2].ToString();
        ////        textBox3.Text = dr[3].ToString();
        ////        textBox4.Text = dr[6].ToString();
        ////        textBox5.Text = dr[4].ToString();
        ////        textBox6.Text = dr[5].ToString();


        ////    }

        ////    //  dr.Close();
        ////    con.Close();
        ////    //c.closeread();
        ////}


       


     
    }
}
