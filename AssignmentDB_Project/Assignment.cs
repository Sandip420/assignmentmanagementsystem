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
    public partial class Assignment : Form
    {
        private bool IsEditMode = false;    //ForEditMode

        public Assignment()
        {
            InitializeComponent();
            TeacherSearch.ForeColor = Color.Gray;
            TeacherSearch.Text = "Search Teacher's Name";
            TeacherSearch.Select(TeacherSearch.TextLength, 0);

            StudentSearch.ForeColor = Color.Gray;
            StudentSearch.Text = "Search Student's Name";
            StudentSearch.Select(StudentSearch.TextLength, 0);

            StatusSearch.ForeColor = Color.Gray;
            StatusSearch.Text = "Search Status's Name";
            StatusSearch.Select(StatusSearch.Text.Length, 0); //ForDataSearch
        }

        private void LoadData()
        {
            string SqlQuery = "Select Assignments.AssignmentId,Teachers.TeacherName as Teacher,Students.StudentName as Student,Subjects.SubjectName as Subject,Statuses.StatusName as Status,Assignments.TeacherId,Assignments.StudentId,Assignments.SubjectId,Assignments.StatusId,Assignments.Comment,Assignments.DateOfSubmission from Assignments join Teachers on Teachers.TeacherId = Assignments.TeacherId join Students on Students.StudentId = Assignments.StudentId join Subjects on Subjects.SubjectId = Assignments.SubjectId join Statuses on Statuses.StatusId = Assignments.StatusId;";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtAssignment.DataSource = dt;                          //ForLoadingDataFromDatabase
        }

        private void LoadTeacherCombo()
        {
            String sql = "Select TeacherId,TeacherName from Teachers;";
            var data = dbconnection.GetTableByQuery(sql);

            cmbTeacher.DataSource = data;
            cmbTeacher.DisplayMember = "TeacherName";
            cmbTeacher.ValueMember = "TeacherId";   //ForLoadingDataInComboboxFromDatabase

        }

        private void LoadStudentCombo()
        {
            String sql = "Select StudentId,StudentName from Students;";
            var data = dbconnection.GetTableByQuery(sql);

            cmbStudent.DataSource = data;
            cmbStudent.DisplayMember = "StudentName";
            cmbStudent.ValueMember = "StudentId";     //ForLoadingDataInComboboxFromDatabase

        }

        private void LoadSubjectCombo()
        {
            String sql = "Select SubjectId,SubjectName from Subjects;";
            var data = dbconnection.GetTableByQuery(sql);

            cmbSubject.DataSource = data;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectId";   //ForLoadingDataInComboboxFromDatabase

        }
       
          private void LoadStatusCombo()
        {
            String sql = "Select StatusId,StatusName from Statuses;";
            var data = dbconnection.GetTableByQuery(sql);

            cmbStatus.DataSource = data;
            cmbStatus.DisplayMember = "StatusName";
            cmbStatus.ValueMember = "StatusId";

            StatusSearch.DataSource = data;
            StatusSearch.DisplayMember = "StatusName";
            StatusSearch.ValueMember = "StatusId"; //ForLoadingDataInComboboxFromDatabase

        }


        private void Assignment_Load(object sender, EventArgs e)
        {
            LoadTeacherCombo();
            LoadStudentCombo();
            LoadSubjectCombo();
            LoadStatusCombo();
            LoadData();

            EnableDisableControl("Reset");
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
                    string Query1 = "Insert into Assignments(AssignmentId,StudentId,TeacherId,SubjectId,StatusId,Comment,DateOfSubmission) values('" + this.txtAssignmentId.Text + "','" + this.cmbStudent.SelectedValue + "','" + this.cmbTeacher.SelectedValue + "','" + this.cmbStatus.SelectedValue + "','" + this.cmbSubject.SelectedValue + "','" + this.txtComment.Text + "','" + this.datetimeSubmission.Value.Date + "');";                 
                    dbconnection.ExecuteNonQuery(Query1);
                    MessageBox.Show("Saved Successfully");  //ToInsertData

                }
                else
                {
                    string Query2 = "Update Assignments set AssignmentId='" + this.txtAssignmentId.Text + "',StudentId='" + this.cmbStudent.SelectedValue + "',TeacherId='" + this.cmbTeacher.SelectedValue + "',SubjectId='" + this.cmbSubject.SelectedValue + "', DateOfSubmission = '" + this.datetimeSubmission.Value.Date + "', StatusId = '" + this.cmbStatus.SelectedValue + "', Comment = '" + this.txtComment.Text + "' where AssignmentId='" + this.txtAssignmentId.Text + "'; ";
                    dbconnection.ExecuteNonQuery(Query2);
                    MessageBox.Show("Edited Sucessfully");   //ToUpdateData
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show(ex.ToString()); 
            }


            }

        private bool ValidateData()
        {
            string sql = "Select * from Assignments where StudentId='" + cmbStudent.SelectedValue + "' and TeacherId='" + cmbTeacher.SelectedValue + "' and SubjectId= '" + cmbStatus.SelectedValue + "';";
            DataTable dt = new DataTable();
            dt = dbconnection.GetTableByQuery(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This assignment already exists.");
                return false;                //ToPreventFromDataDuplication
            }
            if (txtAssignmentId.Text =="" || cmbStudent.Text =="" || cmbStatus.Text =="" || cmbTeacher.Text =="" || cmbSubject.Text ==""  || txtComment.Text =="" || datetimeSubmission.Text =="")
            {
                MessageBox.Show("Please fill up the form completely!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;                 //ForDataValidation
            }
            return true;
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
                String Query = "Delete from Assignments where AssignmentId = '" + this.txtAssignmentId.Text + "' ;";
                dbconnection.ExecuteNonQuery(Query);
                MessageBox.Show("Deleted Successfully");
                LoadData();                   //ToDeleteData
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



        private int GetAssignmentId()
        {
            try
            {
                string SQL = "Select max(AssignmentId)+1 from Assignments";  //ToGetNewId
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
            txtAssignmentId.Text = GetAssignmentId().ToString();

            EnableDisableControl("New");
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            IsEditMode = true;

            EnableDisableControl("Edit");
        }

        private void dtAssignment_DoubleClick(object sender, EventArgs e)
        {
            txtAssignmentId.Text = dtAssignment.CurrentRow.Cells["AssignmentId"].Value.ToString();
            cmbTeacher.SelectedValue = dtAssignment.CurrentRow.Cells["TeacherId"].Value.ToString();
            cmbStudent.SelectedValue = dtAssignment.CurrentRow.Cells["StudentId"].Value.ToString();
            cmbStatus.SelectedValue = dtAssignment.CurrentRow.Cells["SubjectId"].Value.ToString();
            cmbSubject.SelectedValue = dtAssignment.CurrentRow.Cells["StatusId"].Value.ToString();
            txtComment.Text = dtAssignment.CurrentRow.Cells["Comment"].Value.ToString();
            datetimeSubmission.Text = dtAssignment.CurrentRow.Cells["DateOfSubmission"].Value.ToString();

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
                    btnSave.Enabled = false;   //EnableDisableButton

                    txtAssignmentId.Clear();
                    cmbSubject.ResetText();
                    txtComment.Clear();
                    cmbTeacher.ResetText();
                    cmbStudent.ResetText();
                    cmbStatus.ResetText();   //ToResetText

                    datetimeSubmission.Format = DateTimePickerFormat.Custom;
                    datetimeSubmission.CustomFormat = " " ;

                    txtAssignmentId.Enabled = false;
                    txtComment.Enabled = false;
                    cmbSubject.Enabled = false;
                    cmbTeacher.Enabled = false;
                    cmbStudent.Enabled = false;
                    cmbStatus.Enabled = false;
                    datetimeSubmission.Enabled = false;  //EnableDisableTextEditing
                    break;

                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    cmbSubject.ResetText();
                    txtComment.Clear();
                    cmbTeacher.ResetText();
                    cmbStudent.ResetText();
                    cmbStatus.ResetText();
                    datetimeSubmission.Format = DateTimePickerFormat.Custom;
                    datetimeSubmission.CustomFormat = " ";

                    txtAssignmentId.Enabled = false;
                    txtComment.Enabled = true;
                    cmbSubject.Enabled = true;
                    cmbTeacher.Enabled = true;
                    cmbStudent.Enabled = true;
                    cmbStatus.Enabled = true;
                    datetimeSubmission.Enabled = true;
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtAssignmentId.Enabled = true;
                    txtComment.Enabled = true;
                    cmbSubject.Enabled = true;
                    cmbTeacher.Enabled = true;
                    cmbStudent.Enabled = true;
                    cmbStatus.Enabled = true;
                    datetimeSubmission.Enabled = true;
                    break;

                case "DoubleClick":
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = true;

                    txtAssignmentId.Enabled = false;
                    txtComment.Enabled = false;
                    cmbSubject.Enabled = false;
                    cmbTeacher.Enabled = false;
                    cmbStudent.Enabled = false;
                    cmbStatus.Enabled = false;
                    datetimeSubmission.Enabled = false;
                    break;
            }
        }

        private void datetimeSubmission_ValueChanged(object sender, EventArgs e)
        {
            datetimeSubmission.Format = DateTimePickerFormat.Custom;
            datetimeSubmission.CustomFormat = "dddd,dd MMMM, yyyy";
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string SqlQuery = "Select Teachers.TeacherName as Teacher,Students.StudentName as Student,Subjects.SubjectName as Subject,Statuses.StatusName as Status,Assignments.AssignmentId,Assignments.StudentId,Assignments.TeacherId,Assignments.SubjectId,Assignments.StatusId,Assignments.Comment,Assignments.DateOfSubmission from Assignments join Teachers on Teachers.TeacherId=Assignments.TeacherId join Students on Students.StudentId=Assignments.StudentId join Subjects on Subjects.SubjectId=Assignments.SubjectId join Statuses on Statuses.StatusId=Assignments.StatusId where TeacherName like('" + TeacherSearch.Text + "%')";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);  //ForDataSearch
            dtAssignment.DataSource = dt;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            TeacherSearch.Clear();
            TeacherSearch.ForeColor = Color.Black;
        }

        private void btnShowFK_Click(object sender, EventArgs e)
        {
            this.dtAssignment.Columns["TeacherId"].Visible = true;
            this.dtAssignment.Columns["StudentId"].Visible = true;
            this.dtAssignment.Columns["SubjectId"].Visible = true;
            this.dtAssignment.Columns["StatusId"].Visible = true;      //ToShowForeignKey
        }

        private void btnHideFK_Click(object sender, EventArgs e)
        {
            this.dtAssignment.Columns["TeacherId"].Visible = false;
            this.dtAssignment.Columns["StudentId"].Visible = false;
            this.dtAssignment.Columns["SubjectId"].Visible = false;
            this.dtAssignment.Columns["StatusId"].Visible = false;     //ToHideForeignKey
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }






        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void txtSearch_FontChanged(object sender, EventArgs e)
        {

        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string SqlQuery = "Select Teachers.TeacherName as Teacher,Students.StudentName as Student,Subjects.SubjectName as Subject,Statuses.StatusName as Status,Assignments.AssignmentId,Assignments.StudentId,Assignments.TeacherId,Assignments.SubjectId,Assignments.StatusId,Assignments.Comment,Assignments.DateOfSubmission from Assignments join Teachers on Teachers.TeacherId=Assignments.TeacherId join Students on Students.StudentId=Assignments.StudentId join Subjects on Subjects.SubjectId=Assignments.SubjectId join Statuses on Statuses.StatusId=Assignments.StatusId where StudentName like('" + StudentSearch.Text + "%')";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);  //ForDataSearch
            dtAssignment.DataSource = dt;
        }

        private void StatusSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string SqlQuery = "Select Teachers.TeacherName as Teacher,Students.StudentName as Student,Subjects.SubjectName as Subject,Statuses.StatusName as Status,Assignments.AssignmentId,Assignments.StudentId,Assignments.TeacherId,Assignments.SubjectId,Assignments.StatusId,Assignments.Comment,Assignments.DateOfSubmission from Assignments join Teachers on Teachers.TeacherId=Assignments.TeacherId join Students on Students.StudentId=Assignments.StudentId join Subjects on Subjects.SubjectId=Assignments.SubjectId join Statuses on Statuses.StatusId=Assignments.StatusId where StatusName like('" + StatusSearch.Text + "%')";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);  //ForDataSearch
            dtAssignment.DataSource = dt;
        }

        private void StudentSearch_Enter(object sender, EventArgs e)
        {
            StudentSearch.Clear();
            StudentSearch.ForeColor = Color.Black;
        }

        private void StatusSearch_Enter(object sender, EventArgs e)
        {
            StatusSearch.ResetText();
            StatusSearch.ForeColor = Color.Black;
        }

        private void cmbSubject_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void StatusSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
