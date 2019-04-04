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
    public partial class Viewa : Form
    {
        public Viewa()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void listload()         // refreshing list.
        {
            Connect c = new Connect();
            c.getconn();
            string p = "select*from appo";
            c.readata(p);
            while (c.dr.Read())
            {
                ListViewItem it = new ListViewItem(c.dr[7].ToString());
                it.SubItems.Add(c.dr[0].ToString());
                it.SubItems.Add(c.dr[1].ToString());
                it.SubItems.Add(Convert.ToDateTime(c.dr[2]).ToString("dd/mm/yyyy"));

               
                it.SubItems.Add(Convert.ToDateTime(c.dr[3]).ToString("HH:mm:ss"));
               
                it.SubItems.Add(Convert.ToDateTime(c.dr[6]).ToString("HH:mm:ss"));
                it.SubItems.Add(c.dr[4].ToString());
                it.SubItems.Add(c.dr[5].ToString());
                list.Items.Add(it);
            
            }
            }

        public void View_Appointment_Load(object sender, EventArgs e)
        {
            listload();

            
        }


        
        

      
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem ob = list.SelectedItems[0];
            string w = ob.SubItems[0].Text;

            string f = "delete from appo where aname='" + w + "'";
            Connect c = new Connect();
            c.getconn();
            c.save(f);
            MessageBox.Show("Appintment Deleted","Delete Info.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            list.Items.Remove(list.SelectedItems[0]);
            this.Hide();
            Viewa ex = new Viewa();
            ex.Show();
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editapp fd = new Editapp();
            this.Hide();
            fd.Show();
            
        }
    }
}
