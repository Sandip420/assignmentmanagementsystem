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
    public partial class Status : Form
    {
        private bool IsEditMode = false; //EditMode

        public Status()
        {
            InitializeComponent();
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Status Name";
            txtSearch.Select(txtSearch.TextLength, 0); //ForDataSearch
        }

        private void LoadData()
        {
            string SqlQuery = "Select * from Statuses";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtFaculty.DataSource = dt;  //ForLoadingData
        }

        private void Status_Load(object sender, EventArgs e)
        {
            LoadData();

            EnableDisableControl("Reset");
        }

        private bool ValidateData()
        {
            string StatusName = txtStatusName.Text;
            string sql = "Select * from Statuses where StatusName='" + txtStatusName.Text + "';";
              DataTable dt = new DataTable();
            dt = dbconnection.GetTableByQuery(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The status name," +StatusName+  "is already used."); 
                return false;   //ToPreventFromDataDuplication
            }
            if (txtStatusId.Text == "" || txtStatusName.Text == "" )
            {
                MessageBox.Show("Please fill up the form completely !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;   //ForDataValidation 
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {                
                if (IsEditMode == false)
                {
                    if (ValidateData() != true)
                        return;
                    string Query1 = "Insert into  Statuses(StatusId,StatusName) values('" + this.txtStatusId.Text + "','" + this.txtStatusName.Text + "');";
                    dbconnection.ExecuteNonQuery(Query1);
                    MessageBox.Show("Saved Successfully");  //ToInsertData

                }
                else
                {
                    string Query2 = "Update Statuses set StatusId='" + this.txtStatusId.Text + "',StatusName='" + this.txtStatusName.Text + "' where StatusId='" + this.txtStatusId.Text + "';";
                    dbconnection.ExecuteNonQuery(Query2);
                    MessageBox.Show("Edited Sucessfully");  //ToUpdatedata
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
            string Query = "Delete from Statuses where StatusId='" + this.txtStatusId.Text + "';";
            dbconnection.ExecuteNonQuery(Query);
            MessageBox.Show("Deleted Successfully");   //ToDeleteData
            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private int GetStatusId()
        {
            try
            {
                string SQL = "Select max(StatusID)+1 from Statuses";  //ToGetNewId
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
            txtStatusId.Text = GetStatusId().ToString();

            EnableDisableControl("New");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;

            EnableDisableControl("Edit");
        }

        private void dtFaculty_DoubleClick(object sender, EventArgs e)
        {
            txtStatusId.Text = dtFaculty.CurrentRow.Cells["StatusID"].Value.ToString();
            txtStatusName.Text = dtFaculty.CurrentRow.Cells["StatusName"].Value.ToString();

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

                    txtStatusId.Clear();
                    txtStatusName.Clear();   //ToClearText

                    txtStatusId.Enabled = false;
                    txtStatusName.Enabled = false;  //EnableDisableTextEditing
                    break;

                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;    //EnableDisableButton

                    txtStatusName.Clear();    //ToClearText

                    txtStatusId.Enabled = true;
                    txtStatusName.Enabled = true;    //EnableDisableTextEditing
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;  //EnableDisableButton

                    txtStatusId.Enabled = false;
                    txtStatusName.Enabled = true;  //EnableDisableTextEditing
                    break;

                case "DoubleClick":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = true;  //EnableDisableButton

                    txtStatusId.Enabled = false;
                    txtStatusName.Enabled = false;  //EnableDisableTextBox
                    break;
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string SqlQuery = "Select * from Statuses where StatusName like('" + txtSearch.Text + "%')";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtFaculty.DataSource = dt;  //ForDataSearch
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
    }
}
