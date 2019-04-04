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
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }

        string gender;                 // variable for storing gender.
        string filpath;
       
        public void combofil()         // function to fill the combo box for category ie. official/personal staff .
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "Select";
            comboBox1.Items.Add("Official Staff");
            comboBox1.Items.Add("Personal Staff");
        }

        public void clear()  // function for clear button.
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = ""; 
            textBox14.Text = "";
            textBox16.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox9.Text = "Select";
            textBox8.Text = "Select";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            combofil();
           
        }

        private void Form4_Load(object sender, EventArgs e)     // event function during staff registration form.
        {
             this.WindowState = FormWindowState.Maximized;
             combofil();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            fil.Title = "Upload Image";
            if (fil.ShowDialog() == DialogResult.OK)
              {
                filpath = fil.FileName.ToString();
                textBox1.Text = filpath;
                pictureBox1.ImageLocation = filpath;

              }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button5_Click_1(object sender, EventArgs e)    // save button functions..
        {
            Connect c = new Connect();
            c.getconn();
            string q = "insert into staff(Fname,lname,mname,sid,dob,age,sex,doj,officead,resadd,qualification,mobile,email,phone,category,Department,image) values( '" + textBox6.Text + "','" + textBox7.Text + "','" + textBox10.Text + "','" + textBox5.Text + "','" + dateTimePicker2.Text + "','" + textBox2.Text + "','" + gender + "','" + this.dateTimePicker1.Text + "','" + textBox16.Text + "','" + textBox14.Text + "','" + textBox12.Text + "','" + textBox4.Text + "','" + textBox11.Text + "','" + textBox13.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox1.Text+ "')";
            c.save(q);
            MessageBox.Show("Staff Register updated with the given data..","Database Update Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)           // function of clear button ... function definirion described above.
        {
            
            clear();
            pictureBox1.Image = pictureBox1.BackgroundImage;
            
  
        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)    // choosing of gender. if male
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)    // choosing of gender. if female
        {
            gender = "Female";
        }

      

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
           
            textBox8.Text = dateTimePicker1.Text;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)    // Entry of date of birth and age calculation .
        {
            textBox9.Text = dateTimePicker2.Text;

            int years = DateTime.Now.Year - dateTimePicker2.Value.Year;
            if (DateTime.Now.Month < dateTimePicker2.Value.Month
                || (DateTime.Now.Month == dateTimePicker2.Value.Month
                && DateTime.Now.Day < dateTimePicker2.Value.Month))
                years--;
            textBox2.Text = Convert.ToString(years);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox14.Text = textBox16.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 oh = new Form2();
            this.Hide();
            oh.Show();

        }

      


     
       
    }
}
