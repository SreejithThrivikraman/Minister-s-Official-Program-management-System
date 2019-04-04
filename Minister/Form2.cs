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
    public partial class Form2 : Form
    {
       
        Addtrip tr = new Addtrip();
        Form3 pg = new Form3();
        Form4 st = new Form4();
        Form7 ob = new Form7();
        Form6 ob1 = new Form6();
       public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void viewFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recentFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void officeRoutineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void tripToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appoinmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void newTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tr.MdiParent = this;
            tr.Show();
            panel1.SendToBack();


        }

        private void addNewStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            st.MdiParent = this;
            st.Show();
            panel1.SendToBack();

        }

       

        public void send()
        {
            panel1.BringToFront();
        }

        private void officialStaffRegistryToolStripMenuItem_Click(object sender, EventArgs e)  // view official staff registry.
        {

            ob1.MdiParent = this;
            ob1.Show();
            panel1.SendToBack();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ob.MdiParent = this;
            ob.Show();
            panel1.SendToBack();

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Appointment op = new Add_Appointment();
            op.MdiParent = this;
            op.Show();
            panel1.SendToBack();
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Viewa vap = new Viewa();
            vap.MdiParent = this;
            vap.Show();
            panel1.SendToBack();
        }
     }
}
