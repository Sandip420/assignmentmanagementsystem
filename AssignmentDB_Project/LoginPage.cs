using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AssignmentDB_Project
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text =="" || txtPassword.Text=="")
            {
                MessageBox.Show("Please input username and password!!", "Login Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else 
            {
                if (txtPassword.Text.Length < 6)
                {
                   MessageBox.Show("Password must be at least 6 characters long.");
                   return;
                }
                this.Hide();
                MDI f = new MDI();
                f.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button1_MouseClick(sender, null);
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginPage_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void LoginPage_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void LoginPage_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}   
