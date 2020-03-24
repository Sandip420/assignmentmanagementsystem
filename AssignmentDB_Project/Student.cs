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
    public partial class Student : Form
    {
        private bool IsEditMode = false;   //ForEditMode
        public Student()
        {
            InitializeComponent();
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Student Name";
            txtSearch.Select(txtSearch.TextLength, 0); //ForDataSearch

        }

        private void LoadData()
        {
            string SqlQuery = "Select Students.StudentId,Students.StudentName,Students.Section,Students.EmailAddress,Students.ContactNo,Students.Remarks,Students.FacultyId,Faculties.FacultyName as Faculty_Name from Students join Faculties on Students.FacultyId=Faculties.FacultyId;";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dataGridView.DataSource = dt; //ForLoadingData
        }

        private void LoadFacultyCombo()
        {
            String sql = "select FacultyId,FacultyName" + " from Faculties";
            var data = dbconnection.GetTableByQuery(sql);

            cmbFaculty.DataSource = data;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyId";  ////ForLoadingDataInCombobox

        }

        private void Student_Load(object sender, EventArgs e)
        {
            LoadFacultyCombo();
            LoadData();

            EnableDisableControl("Reset");
            //cmbFaculty.ResetText();
        }

        private bool ValidateData()
        {
            string StudentName = txtStudentName.Text;
            string sql = "Select * from Students where StudentName ='" + txtStudentName.Text + "' and EmailAddress='" + txtEmailAddress.Text + "' and ContactNo='"+txtContactNo.Text+"';";
            DataTable dt = new DataTable();
            dt = dbconnection.GetTableByQuery(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The student name,"+ StudentName + " already exists.");
                return false;                //ToPreventFromDataDuplication
            }
            if (txtStudentId.Text == "" || txtStudentName.Text == "" || txtSection.Text == "" || txtEmailAddress.Text =="" || txtContactNo.Text=="" || txtRemarks.Text =="" || cmbFaculty.Text =="")
            {
                MessageBox.Show("Please fill up the form completely !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;                //ForDataValidation
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() != true)
                {
                    return;
                }

                if (IsEditMode == false)
                {
                    string Query1 = "Insert into  Students values('" + this.txtStudentId.Text + "','" + this.txtStudentName.Text + "','" + this.txtSection.Text + "','" + this.txtEmailAddress.Text + "','" + this.txtContactNo.Text + "','" + this.txtRemarks.Text + "','" + this.cmbFaculty.SelectedValue + "');";
                    dbconnection.ExecuteNonQuery(Query1);
                    MessageBox.Show("Saved Successfully");  //ToInsertData

                }
                else
                {
                    string Query2 = "Update Students Set StudentId='" + this.txtStudentId.Text + "',StudentName='" + this.txtStudentName.Text + "',EmailAddress='" + this.txtEmailAddress.Text + "',ContactNo='" + this.txtContactNo.Text + "',Section='" + this.txtSection.Text + "',Remarks='" + this.txtRemarks.Text + "',FacultyId='" + this.cmbFaculty.SelectedValue + "' where StudentId='" + this.txtStudentId.Text + "';";
                    dbconnection.ExecuteNonQuery(Query2);
                    MessageBox.Show("Edited Sucessfully");  //ToUpdateData
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
            try
            { 
            DialogResult a;
            a = MessageBox.Show("Are you sure to delete data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.No)
            {
                return;
            }
            string Query = "Delete from Students where StudentId='" + this.txtStudentId.Text + "';";
            dbconnection.ExecuteNonQuery(Query);
            MessageBox.Show("Deleted Successfully");  //ToDeleteData
            LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.ToString()); 
            }

}

        private void btnReset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private int GetStudentId()
        {
            try
            {
                string SQL = "select max(StudentID)+1 from Students"; //ToGetNewId
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
            txtStudentId.Text = GetStudentId().ToString();

            EnableDisableControl("New");
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            IsEditMode = true;

            EnableDisableControl("Edit");
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            txtStudentId.Text = dataGridView.CurrentRow.Cells["StudentId"].Value.ToString();
            txtStudentName.Text = dataGridView.CurrentRow.Cells["StudentName"].Value.ToString();
            txtSection.Text = dataGridView.CurrentRow.Cells["Section"].Value.ToString();
            txtEmailAddress.Text = dataGridView.CurrentRow.Cells["EmailAddress"].Value.ToString();
            txtContactNo.Text = dataGridView.CurrentRow.Cells["ContactNo"].Value.ToString();
            txtRemarks.Text = dataGridView.CurrentRow.Cells["Remarks"].Value.ToString();
            cmbFaculty.SelectedValue = dataGridView.CurrentRow.Cells["FacultyId"].Value.ToString();

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
                    btnSave.Enabled = false;  //EnableDisableButton

                    txtStudentId.Clear();
                    txtStudentName.Clear();
                    txtEmailAddress.Clear();
                    txtContactNo.Clear();
                    txtRemarks.Clear();
                    txtSection.Clear();
                    cmbFaculty.ResetText(); //ToResetText

                    txtStudentId.Enabled = false;
                    txtStudentName.Enabled = false;
                    txtSection.Enabled = false;
                    txtEmailAddress.Enabled = false;
                    txtContactNo.Enabled = false;
                    txtRemarks.Enabled = false;
                    cmbFaculty.Enabled = false;  //EnableDisableTextEditing
                    break;

                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtStudentName.Clear();
                    txtEmailAddress.Clear();
                    txtContactNo.Clear();
                    txtRemarks.Clear();
                    txtSection.Clear();
                    cmbFaculty.ResetText();

                    txtStudentId.Enabled = false;
                    txtStudentName.Enabled = true;
                    txtSection.Enabled = true;
                    txtEmailAddress.Enabled = true;
                    txtContactNo.Enabled = true;
                    txtRemarks.Enabled = true;
                    cmbFaculty.Enabled = true;
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtStudentId.Enabled = true;
                    txtStudentName.Enabled = true;
                    txtSection.Enabled = true;
                    txtEmailAddress.Enabled = true;
                    txtContactNo.Enabled = true;
                    txtRemarks.Enabled = true;
                    cmbFaculty.Enabled = true;
                    break;

                case "DoubleClick":
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = true;

                    txtStudentId.Enabled = false;
                    txtStudentName.Enabled = false;
                    txtSection.Enabled = false;
                    txtEmailAddress.Enabled = false;
                    txtContactNo.Enabled = false;
                    txtRemarks.Enabled = false;

                    cmbFaculty.Enabled = false;
                    break;
            }
        }

        private void btnShowFK_Click_1(object sender, EventArgs e)
        {
            this.dataGridView.Columns["FacultyId"].Visible = true; //ToShowForeignKey
        }

        private void btnHideFK_Click(object sender, EventArgs e)
        {
            this.dataGridView.Columns["FacultyId"].Visible = false; //ToHideForeignKey
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string SqlQuery = "select * from Students where StudentName like('" + txtSearch.Text + "%')";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery); //ForDataSearch
            dataGridView.DataSource = dt;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide(); 
        }






        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void facid_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
    
}
