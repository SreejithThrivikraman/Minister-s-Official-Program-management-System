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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)   // login button.
        { 
        }

        private void radioButton1_MouseHover(object sender, EventArgs e)
        {
            radioButton2.Visible = false;
        }

        private void radioButton1_MouseLeave(object sender, EventArgs e)
        {

            radioButton2.Visible = true;
        }

        private void radioButton2_MouseHover(object sender, EventArgs e)
        {
            radioButton1.Visible = false;

             if(radioButton1.Checked)
                {
                   radioButton2.Visible =false;
 
                }
        }

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
               if( radioButton2.Checked)
                {
                   radioButton1.Visible =false;
 
                }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void login_Click_1(object sender, EventArgs e)
        {
            try
            {
                Connect c = new Connect();
                c.getconn();

                string str;
                str = "select * from login where logname =@u and pass =@p";

                c.exe(str);                                            // executing command in sql database.  # refer class1.
                c.cd.Parameters.AddWithValue("@u", this.textBox1.Text); // copying values at textboxes.
                c.cd.Parameters.AddWithValue("@p", this.textBox2.Text);
                c.dr = c.cd.ExecuteReader();                           // authentication code.
                while (c.dr.Read())
                {
                    if (c.dr.HasRows == true)
                    {
                        Form2 fm = new Form2();
                        fm.Show();
                        this.Hide();
                    }
                }
                if (c.dr.HasRows == false)                           // blocking unauthorised login .
                {
                    MessageBox.Show("Access to database Denied !!! ", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                c.con.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Connection Error !! Sorry for the inconvinence." + ee);
            }
              
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
       
      }
    }

    

