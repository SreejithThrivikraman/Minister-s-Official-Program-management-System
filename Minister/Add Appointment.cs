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
    public partial class Add_Appointment :Form
    {
       
        public Add_Appointment()
        {
            InitializeComponent();
        }
        Form2 op = new Form2();

        public void clear()  // function for clear button.
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";



        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public void combofil()         // function to fill the combo box 
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Select";
            comboBox1.Items.Add("To visit");
            comboBox1.Items.Add("Office meet");
        }
        private void Add_Appointment_Load(object sender, EventArgs e)
        {
            combofil();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)   // checking availability
        {
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Connect c = new Connect();
            c.getconn();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Fill all the fields and continue", "Error Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                

            }
            else
            {
                string q = "insert into appo values( '" + textBox1.Text + "','" + comboBox1.SelectedItem + "','" + dateTimePicker1.Text + "','" + dateTimePicker3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" +dateTimePicker2.Text +"')";
                c.save(q);
                MessageBox.Show("Appointment created.", "Appoin.Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {   
            this.Hide();
            op.Show();
            
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Text;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
         
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = dateTimePicker2.Text;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            textBox6.Text = dateTimePicker3.Text;
           

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)     // save button.
        {
            Connect c = new Connect();
            c.getconn();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Fill all the fields and continue", "Error Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                string q = "insert into appo values( '" + textBox1.Text + "','" + comboBox1.SelectedItem + "','" + dateTimePicker1.Text + "','" + dateTimePicker3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker2.Text + "','"+textBox7.Text+"')";
                c.save(q);
                MessageBox.Show("Appointment created.", "Appoin.Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)   // cancel button.
        {
            this.Hide();
            op.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
