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
    public partial class Teacher : Form
    {
        private bool IsEditMode = false;
        public Teacher()
        {
            InitializeComponent();
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Teacher Name";
            txtSearch.Select(txtSearch.TextLength, 0);
        }
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP - MKNI10Q\SQLEXPRESS;Initial Catalog = AssignmentDB; Integrated Security = True");
       
        private void LoadData()
        {
            string SqlQuery = "Select * from Teachers";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtTeacher.DataSource = dt;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private bool ValidateData()
        {
            string TeacherName = txtTeacherName.Text;
            string sql = "Select * from Teachers where TeacherName ='" + txtTeacherName.Text + "' and EmailAddress='" + txtEmailAddress.Text + "' and ContactNo='" + txtContactNo.Text + "';";
            DataTable dt = new DataTable();
            dt = dbconnection.GetTableByQuery(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The teacher name," + TeacherName + " already exists.");
                return false;                //ToPreventFromDataDuplication
            }
            if (txtTeacherId.Text == "" || txtTeacherName.Text == "" || txtEmailAddress.Text == "" || txtContactNo.Text == "")
            {
                MessageBox.Show("Please fill up the form completely !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;                //ForDataValidation
            }
            return true;
            //if (txtTeacherName.Text == "")
            //{
            //    MessageBox.Show("Enter TeacherName!", "Data Validation Problem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            //if (txtEmailAddress.Text == "")
            //{
            //    MessageBox.Show("Enter EmailAddress!", "Data Validation Problem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            //if (txtContactNo.Text == "")
            //{ 
            //    MessageBox.Show("Enter ContactNo!", "Data Validation Problem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}

        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            try
            {
                if (IsEditMode == false)
                {
                    if (ValidateData() != true)
                    {
                        return;
                    }
                    string sql = "Insert into Teachers(TeacherID,TeacherName,EmailAddress,ContactNo)values('" + txtTeacherId.Text + "','" + txtTeacherName.Text + "','" + txtEmailAddress.Text + "','" + txtContactNo.Text + "')";
                    dbconnection.ExecuteNonQuery(sql);
                    MessageBox.Show("Saved succcessfully");
                }
                else
                {
                    string sqlUpdate = "Update Teachers set TeacherId='" + txtTeacherId.Text + "',TeacherName='" + txtTeacherName.Text + "',EmailAddress='" + txtEmailAddress.Text + "',ContactNo='" + txtContactNo.Text + "' where TeacherId='" + txtTeacherId.Text + "';";
                    dbconnection.ExecuteNonQuery(sqlUpdate);
                    MessageBox.Show("Edited succcessfully");

                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.ToString()); 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult a;
            a = MessageBox.Show("Are you sure to delete data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.No)
            {
                return;
            }
            string sql = "Delete from Teachers where TeacherId=" + txtTeacherId.Text + ";";
            dbconnection.ExecuteNonQuery(sql);
            MessageBox.Show("Deleted Successfully");
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {           
            EnableDisableControl("Reset");
        }

        private int GetTeacherId()
        {
            try
            {
                string SQL = "Select max(TeacherID)+1 from Teachers";
                var data = dbconnection.GetTableByQuery(SQL);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            txtTeacherId.Text = GetTeacherId().ToString();

            EnableDisableControl("New");
        }

        private void btnEdit_Click_2(object sender, EventArgs e)
        {
            IsEditMode = true;

            EnableDisableControl("Edit");
        }

        private void dtTeacher_DoubleClick(object sender, EventArgs e)
        {
            txtTeacherId.Text = dtTeacher.CurrentRow.Cells["TeacherID"].Value.ToString();
            txtTeacherName.Text = dtTeacher.CurrentRow.Cells["TeacherName"].Value.ToString();
            txtEmailAddress.Text = dtTeacher.CurrentRow.Cells["EmailAddress"].Value.ToString();
            txtContactNo.Text = dtTeacher.CurrentRow.Cells["ContactNo"].Value.ToString();

            EnableDisableControl("DoubleClick");
        }


        private void EnableDisableControl(string mode)
        {
            switch (mode)
            {
                case "Reset":
                    btnNew.Enabled = true;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;

                    txtTeacherId.Clear();
                    txtTeacherName.Clear();
                    txtEmailAddress.Clear();
                    txtContactNo.Clear();

                    txtTeacherId.Enabled = false;
                    txtTeacherName.Enabled = false;
                    txtEmailAddress.Enabled = false;
                    txtContactNo.Enabled = false;
                    break;
                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtTeacherName.Clear();
                    txtEmailAddress.Clear();
                    txtContactNo.Clear();

                    txtTeacherId.Enabled = false;
                    txtTeacherName.Enabled = true;
                    txtEmailAddress.Enabled = true;
                    txtContactNo.Enabled = true;
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtTeacherId.Enabled = true;
                    txtTeacherName.Enabled = true;
                    txtEmailAddress.Enabled = true;
                    txtContactNo.Enabled = true;
                    break;

                case "DoubleClick":
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = true;

                    txtTeacherId.Enabled = false;
                    txtTeacherName.Enabled = false;
                    txtEmailAddress.Enabled = false;
                    txtContactNo.Enabled = false;
                    break;
            }

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string SqlQuery = "select * from Teachers where TeacherName like('" + txtSearch.Text + "%')";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtTeacher.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

       








        private void button6_Click(object sender, EventArgs e)
        {
        }

        

        private void dtTeacher_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            
        }

        

        

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dtTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
