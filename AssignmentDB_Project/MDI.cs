using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDB_Project
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Faculty f = new Faculty();
            f.Show();
            f.MdiParent = this;  
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Teacher f = new Teacher();
            f.Show();
            f.MdiParent = this;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student f = new Student();
            f.Show();
            f.MdiParent = this;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Subject f = new Subject();
            f.Show();
            f.MdiParent = this;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Assignment f = new Assignment();
            f.Show();
            f.MdiParent = this;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //TeacherDispatch f = new TeacherDispatch();
            //f.Show();
            //f.MdiParent = this;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage f = new LoginPage();
            f.ShowDialog();


        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Status f = new Status();
            f.Show();
            f.MdiParent = this;
        }
    }
}
