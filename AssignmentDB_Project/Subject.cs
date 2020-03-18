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
    public partial class Subject : Form
    {
        private bool IsEditMode = false;  //ForEditMode

        public Subject()
        {
            InitializeComponent();
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Subject Name";
            txtSearch.Select(txtSearch.TextLength, 0); //ForDataSearch
        }

        private void LoadData()
        {
            string SqlQuery = "Select SubjectId,SubjectName,Remarks from Subjects";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtSubject.DataSource = dt;  //ForLoadingDataFromDatabase
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableDisableControl("Reset");
        }

        private bool ValidateData()
        {
            string SubjectName = txtSubjectName.Text;
            string sql = "Select * from Subjects where SubjectName='" + txtSubjectName.Text + "';";
            DataTable dt = new DataTable();
            dt = dbconnection.GetTableByQuery(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("The subject name," + SubjectName + " already exists.");
                return false;   //ToPreventFromDataDuplication
            }
            if (txtSubjectId.Text == "" || txtSubjectName.Text == "" || txtRemarks.Text == "")
            {
                MessageBox.Show("Please fill up the form completely !", "Data Validation Problem", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    string Query1 = "Insert into Subjects(SubjectId,SubjectName,Remarks) values('" + this.txtSubjectId.Text + "','" + this.txtSubjectName.Text + "','" + this.txtRemarks.Text + "');";
                    dbconnection.ExecuteNonQuery(Query1);
                    MessageBox.Show("Saved Successfully"); //ToInsertData

                }
                else
                {
                    string Query2 = "Update Subjects set SubjectId='" + this.txtSubjectId.Text + "',SubjectName='" + this.txtSubjectName.Text + "',Remarks='" + this.txtRemarks.Text + "' where SubjectId='" + this.txtSubjectId.Text + "';"; ;
                    dbconnection.ExecuteNonQuery(Query2);
                    MessageBox.Show("Edited Sucessfully");  //ToEditData
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
            string Query = "Delete from Subjects where SubjectId='" + this.txtSubjectId.Text + "';";
            dbconnection.ExecuteNonQuery(Query);
            MessageBox.Show("Deleted Successfully"); //ToDeleteData
            LoadData();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            
            EnableDisableControl("Reset");
        }

        private int GetSubjectId()
        {
            try
            {
                string SQL = "Select max(SubjectId)+1 from Subjects"; //ToGetNewId
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
            txtSubjectId.Text = GetSubjectId().ToString();

            EnableDisableControl("New");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            IsEditMode = true;

            EnableDisableControl("Edit");
        }

        private void dtSubject_DoubleClick(object sender, EventArgs e)
        {
            txtSubjectId.Text = dtSubject.CurrentRow.Cells["SubjectId"].Value.ToString();
            txtSubjectName.Text = dtSubject.CurrentRow.Cells["SubjectName"].Value.ToString();
            txtRemarks.Text = dtSubject.CurrentRow.Cells["Remarks"].Value.ToString();

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

                    txtSubjectId.Clear();
                    txtSubjectName.Clear();
                    txtRemarks.Clear();

                    txtSubjectId.Enabled = false;
                    txtSubjectName.Enabled = false;
                    txtRemarks.Enabled = false;
                    break;
                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtSubjectName.Clear();
                    txtRemarks.Clear();

                    txtSubjectId.Enabled = false;
                    txtSubjectName.Enabled = true;
                    txtRemarks.Enabled = true;
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;

                    txtSubjectId.Enabled = true;
                    txtSubjectName.Enabled = true;
                    txtRemarks.Enabled = true;

                    break;

                case "DoubleClick":
                    btnNew.Enabled = true;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = true;

                    txtSubjectId.Enabled = false;
                    txtSubjectName.Enabled = false;
                    txtRemarks.Enabled = false;
                    break;
            }

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string SqlQuery = "Select * from Subjects where SubjectName like('" + txtSearch.Text + "%')";
            DataTable dt = dbconnection.GetTableByQuery(SqlQuery);
            dtSubject.DataSource = dt;
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








        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        

        private void button4_Click(object sender, EventArgs e)
        {


           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void remk_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void dtSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
