using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Editapp : Form
    {
        public Editapp()
        {
            InitializeComponent();
        }
        SqlCommand cd;
        SqlConnection con;
        SqlDataReader dr;
        public Connect c = new Connect();
        public void addcombo()               // for autocompleting item in the search box.
        {


            c.getconn();
            string q = "select * from appo";
            c.save(q);
            c.readata(q);

            try
            {
                while (c.dr.Read())
                {
                    if (c.dr.HasRows == true)
                    {

                        comboBox2.Items.Add(c.dr[0]);
                    }


                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("ex", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void combofill()
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Select";
            comboBox1.Items.Add("To visit");
            comboBox1.Items.Add("Office meet");
        }

        private void Editapp_Load(object sender, EventArgs e)
        {
            addcombo();
            combofill();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)   // loading of data from database to form.
        {
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e )              //edit   
        {

            con = new SqlConnection(@"Data Source=sree-PC;Initial Catalog=Office;User ID=sa;Password=s");
            con.Open();

            string w = "select * from appo where aname= '" + comboBox2.Text + "'";
            cd = new SqlCommand(w, con);
            dr = cd.ExecuteReader();
            
            string t;
            while (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox7.Text = dr[1].ToString();
                textBox2.Text = Convert.ToDateTime(dr[2]).ToString("dd/MM/yyyy");
                textBox3.Text = Convert.ToDateTime(dr[3]).ToString("HH:mm:ss");

                textBox4.Text = Convert.ToDateTime(dr[6]).ToString("HH:mm:ss");
                
                textBox8.Text=dr[7].ToString();
                textBox5.Text = dr[4].ToString();
                textBox6.Text = dr[5].ToString();


            }

            //  dr.Close();
            con.Close();
            //c.closeread();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox7.Text = comboBox1.Text;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = dateTimePicker3.Text;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox4.Text = dateTimePicker2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Text;
        }

        private void button1_Click(object sender, EventArgs e)   //  update button.
        {

               Connect c = new Connect();
            c.getconn();



            string q = "update appo set aname='" + textBox1.Text + "',category='" +comboBox1.Text + "',date='" + dateTimePicker1.Text + "',time='" + dateTimePicker3.Text + "',matter='" + textBox5.Text + "',place='" + textBox6.Text + "',ftime='" + dateTimePicker2.Text + "' where appno=" + textBox8.Text + "";
            c.save(q);
                MessageBox.Show("Appointment updated.", "Appoin.Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        

        private void button2_Click(object sender, EventArgs e)      //clear button
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
           

        }

        private void button3_Click(object sender, EventArgs e)   // cancel button.
        {
           
            this.Hide();
          

        }

      
      

       


        

      

       
    }

}