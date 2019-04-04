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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cd;
        public SqlDataReader dr;

        Connect c = new Connect();

        public DataSet ds;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            addcombo();
        }

        public void addcombo()             // for autocompleting item in the search box.
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
                        //string g =  c.dr.GetString(Convert.ToInt32("Fname"));
                        comboBox1.Items.Add(c.dr[0]);
                    }

                   
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ex", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            c.closeread();


        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void glassButton4_Click(object sender, EventArgs e)     // delete button.
        {
            string d = "Delete from staff where Fname='"+comboBox1.Text+"'";
            c.save(d);
            MessageBox.Show("Staff Record for ID : "+textBox6.Text+"is deleted Sucessfully","Delete Info",MessageBoxButtons.OK,MessageBoxIcon.Information );
            clear();

        }

      

        public void autocomp()     // auto completion of the search text box.
        {
            
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=sree-PC;Initial Catalog=Office;User ID=sa;Password=s");
            con.Open(); 

            string w = "select * from staff where Fname= '"+comboBox1.Text+"'" ;
            cd = new SqlCommand(w, con);
            dr = cd.ExecuteReader();

            while (dr.Read())
            {
                textBox3.Text = dr[0].ToString();
                textBox4.Text = dr[1].ToString();
                textBox5.Text = dr[2].ToString();
                textBox6.Text = dr[3].ToString();
                textBox8.Text = dr[14].ToString();
                textBox9.Text = dr[15].ToString();
                pictureBox2.ImageLocation=dr[16].ToString();

                   
              }

          //  dr.Close();
            con.Close();
            //c.closeread();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            pictureBox2.ImageLocation = null;
            c.closed1();
        }

        private void glassButton1_Click_1(object sender, EventArgs e)
        {
            clear();   
        }
    }
}
