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
    public partial class TeacherDispatch : Form
    {
        private bool IsEditMode = false;
        public TeacherDispatch()
        {
            InitializeComponent();
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Teacher Dispatch Id";
            txtSearch.Select(txtSearch.TextLength, 0);
        }


        private void LoadData()
        {
            string SqlQuery = "Select TeacherDispatchId,AssignmentId,IsReturn,Remarks,DateOfDispatch from TeacherDispatches";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtTeacherDispatch.DataSource = dt;
        }

        private void LoadAssignmentCombo()
        {
            String sql = "Select AssignmentId from Assignments";
            var data = dbconnection.GetTableByQuery(sql);

            cmbAssignmentId.DataSource = data;
            cmbAssignmentId.DisplayMember = "AssignmentId";
        }

        private void TeacherDispatch_Load(object sender, EventArgs e)
        {
            LoadAssignmentCombo();
            LoadData();

            EnableDisableControl("Reset");
        }

        private bool ValidateData()
        {           
            string sql = "Select * from TeacherDispatches where AssignmentId='" + cmbAssignmentId.SelectedValue + "';";
            DataTable dt = new DataTable();
            dt = dbconnection.GetTableByQuery(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This teacher dispatch already exists.");
                return false;                //ToPreventFromDataDuplication
            }
            if (txtTeacherDispatchId.Text == "" || cmbAssignmentId.Text =="" || checkboxIsReturn.Text =="" || dtpDateOfDispatch.Text == "" || txtRemarks.Text == "")
            {
                MessageBox.Show("Please fill up the form completely !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;               //ForDataValidation
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsEditMode == false)
                {
                    //if (ValidateData() != true)
                    //{
                    //    return;
                    //}
                    string Query1 = "Insert into TeacherDispatches(TeacherDispatchId,AssignmentId,DateOfDispatch,IsReturn,Remarks) values('" + this.txtTeacherDispatchId.Text + "','" + this.cmbAssignmentId.SelectedValue + "','" + this.dtpDateOfDispatch.Value.Date + "','" + this.checkboxIsReturn.Text + "','" + this.txtRemarks.Text + "');";
                    dbconnection.ExecuteNonQuery(Query1);
                    MessageBox.Show("Saved Successfully");
                }

                else
                {
                    string Query2 = "Update TeacherDispatches Set TeacherDispatchId='" + this.txtTeacherDispatchId.Text + "',AssignmentId='" + this.cmbAssignmentId.SelectedValue + "', Remarks = '" + this.txtRemarks.Text + "', IsReturn = '" + this.checkboxIsReturn.Checked + "',DateOfDispatch='" + this.dtpDateOfDispatch.Value.Date + "' where TeacherDispatchId='" + this.txtTeacherDispatchId.Text + "'; ";
                    dbconnection.ExecuteNonQuery(Query2);
                    MessageBox.Show("Edited Sucessfully");

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
                string Query = "Delete from TeacherDispatches where TeacherDispatchId='" + this.txtTeacherDispatchId.Text + "';";
                dbconnection.ExecuteNonQuery(Query);
                MessageBox.Show("Deleted Successfully");
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
            IsEditMode = false;

            EnableDisableControl("Reset");
        }

        private int GetTeacherDispatchId()
        {
            try
            {
                string SQL = "Select max(TeacherDispatchId)+1 from TeacherDispatches";
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
            txtTeacherDispatchId.Text = GetTeacherDispatchId().ToString();

            EnableDisableControl("New");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;

            EnableDisableControl("Edit");
        }

        private void dtTeacherDispatch_DoubleClick(object sender, EventArgs e)
        {
            txtTeacherDispatchId.Text = dtTeacherDispatch.CurrentRow.Cells["TeacherDispatchId"].Value.ToString();
            cmbAssignmentId.Text = dtTeacherDispatch.CurrentRow.Cells["AssignmentID"].Value.ToString();
            txtRemarks.Text = dtTeacherDispatch.CurrentRow.Cells["Remarks"].Value.ToString();
            dtpDateOfDispatch.Text = dtTeacherDispatch.CurrentRow.Cells["DateOfDispatch"].Value.ToString();
            checkboxIsReturn.Text = dtTeacherDispatch.CurrentRow.Cells["IsReturn"].Value.ToString();

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

                    txtTeacherDispatchId.Clear();
                    cmbAssignmentId.ResetText();                   
                    txtRemarks.Clear();
                    dtpDateOfDispatch.Format = DateTimePickerFormat.Custom;
                    dtpDateOfDispatch.CustomFormat = " ";
                    checkboxIsReturn.Text="";

                    txtTeacherDispatchId.Enabled = false;
                    txtRemarks.Enabled = false;
                    cmbAssignmentId.Enabled = false;
                    dtpDateOfDispatch.Enabled = false;
                    checkboxIsReturn.Enabled = false;
                    break;

                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    cmbAssignmentId.ResetText();
                    txtRemarks.Clear();
                    dtpDateOfDispatch.Format = DateTimePickerFormat.Custom;
                    dtpDateOfDispatch.CustomFormat = " ";
                    checkboxIsReturn.Text = "";

                    txtTeacherDispatchId.Enabled = false;
                    txtRemarks.Enabled = true;
                    cmbAssignmentId.Enabled = true;
                    dtpDateOfDispatch.Enabled = true;
                    checkboxIsReturn.Enabled = true;
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtTeacherDispatchId.Enabled = true;
                    txtRemarks.Enabled = true;
                    cmbAssignmentId.Enabled = true;
                    dtpDateOfDispatch.Enabled = true;
                    checkboxIsReturn.Enabled = true;
                    break;

                case "DoubleClick":
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = true;

                    txtTeacherDispatchId.Enabled = false;
                    txtRemarks.Enabled = false;
                    cmbAssignmentId.Enabled = false;
                    dtpDateOfDispatch.Enabled = false;
                    checkboxIsReturn.Enabled =false;
                    break;
            }
        }
        private void datetimeDispatch_ValueChanged(object sender, EventArgs e)
        {
            dtpDateOfDispatch.Format = DateTimePickerFormat.Custom;
            dtpDateOfDispatch.CustomFormat = "dddd,dd MMMM,yyyy";

           
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
            {
                string SqlQuery = "Select * from TeacherDispatches where TeacherDispatchId like('" + txtSearch.Text + "%')";
                DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
                dtTeacherDispatch.DataSource = dt;
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








            private void dtTeacherDispatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void button7_Click(object sender, EventArgs e)
            {

            }

            private void button4_Click(object sender, EventArgs e)
            {

            }

            private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cboxIsReturn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
