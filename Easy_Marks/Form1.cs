using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Marks
{
    public partial class Form1 : Form
    {
        DataHandler dh = new DataHandler();
        public Form1()
        {
            InitializeComponent();
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panelStudents.Visible = true;
            panelSubject.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panelStudents.Visible = false;
            panelSubject.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelNew.Visible=true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            panelEdit.Visible = true;
            panelNew.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int grno=Convert.ToInt32(txtGr_No.Text.ToString());
            int rollno = Convert.ToInt32(drpRollNo.SelectedItem.ToString());
           String name = txtName.Text.ToString();
            
            dh.Insert_student(grno,rollno,name);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
