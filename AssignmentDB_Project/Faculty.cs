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
    public partial class Faculty : Form
    {
        private bool IsEditMode = false;  //ForEditMode

        public Faculty()
        {
            InitializeComponent();
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Faculty Name";
            txtSearch.Select(txtSearch.TextLength, 0);  //ForDataSearch
        }

        private void LoadData()
        {
            string SqlQuery = "Select * from Faculties";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtFaculty.DataSource = dt;  //ForLoadingDataFromDatabase
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
            LoadData();

            EnableDisableControl("Reset");

        }

        private bool ValidateData()
        {
            string FacultyName = txtFacultyName.Text;
            string sql = "Select * from Faculties where FacultyName ='" + txtFacultyName.Text + "' ;";
            DataTable dt = new DataTable();
            dt = dbconnection.GetTableByQuery(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The faculty name," + FacultyName + " already exists.");
                return false;   //ToPreventFromDataDuplication
            }
            if (txtFacultyId.Text == "" || txtFacultyName.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please fill up the form completely!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;  //ForDataValidation
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
                    {
                        return;
                    }
                    string Query1 = "Insert into  Faculties(FacultyId,FacultyName,Description) values('" + this.txtFacultyId.Text + "','" + this.txtFacultyName.Text + "','" + this.txtDescription.Text + "');";
                    dbconnection.ExecuteNonQuery(Query1);
                    MessageBox.Show("Saved Successfully"); //ToInsertData

                }
                else
                {
                    string Query2 = "Update Faculties set FacultyId='" + this.txtFacultyId.Text + "',FacultyName='" + this.txtFacultyName.Text + "',Description='" + this.txtDescription.Text + "' where FacultyId='" + this.txtFacultyId.Text + "';";
                    dbconnection.ExecuteNonQuery(Query2);
                    MessageBox.Show("Edited Sucessfully"); //ToUpdatedata
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
            string Query = "Delete from Faculties where FacultyId='" + this.txtFacultyId.Text + "';";
            dbconnection.ExecuteNonQuery(Query);
            MessageBox.Show("Deleted Successfully"); //ToDeleteData
            LoadData();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {        
            EnableDisableControl("Reset");
        }

        private int GetFacultyId()
        {
            try
            {
                string SQL = "Select max(FacultyID)+1 from Faculties"; //ToGetNewId
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
            txtFacultyId.Text = GetFacultyId().ToString();

            EnableDisableControl("New");
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            IsEditMode = true;

            EnableDisableControl("Edit");
        }
        private void dtFaculty_DoubleClick(object sender, EventArgs e)
        {
            txtFacultyId.Text = dtFaculty.CurrentRow.Cells["FacultyID"].Value.ToString();
            txtFacultyName.Text = dtFaculty.CurrentRow.Cells["FacultyName"].Value.ToString();
            txtDescription.Text = dtFaculty.CurrentRow.Cells["Description"].Value.ToString();

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

                    txtFacultyId.Clear();
                    txtFacultyName.Clear();
                    txtDescription.Clear(); //ToResetText

                    txtFacultyId.Enabled = false;
                    txtFacultyName.Enabled = false;
                    txtDescription.Enabled = false; //EnableDisableTextEditing
                    break;

                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtFacultyName.Clear();
                    txtDescription.Clear();

                    txtFacultyId.Enabled = false;
                    txtFacultyName.Enabled = true;
                    txtDescription.Enabled = true;
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtFacultyId.Enabled = true;
                    txtFacultyName.Enabled = true;
                    txtDescription.Enabled = true;
                    break;

                case "DoubleClick":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = true;

                    txtFacultyId.Enabled = false;
                    txtFacultyName.Enabled = false;
                    txtDescription.Enabled = false;
                    break;
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string SqlQuery = "Select * from Faculties where FacultyName like('" + txtSearch.Text + "%')";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtFaculty.DataSource = dt;
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










        private void button1_Click(object sender, EventArgs e)
        {
        }

        

       

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void dtFaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search(object sender, EventArgs e)
        {

        }

        
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            
        }

        private void SearchBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtFaculty_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}