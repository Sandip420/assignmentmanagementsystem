namespace AssignmentDB_Project
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHideFK = new System.Windows.Forms.Button();
            this.btnShowFK = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.facultiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentDBDataSet1 = new AssignmentDB_Project.AssignmentDBDataSet1();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentDBDataSet = new AssignmentDB_Project.AssignmentDBDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.facultiesTableAdapter = new AssignmentDB_Project.AssignmentDBDataSetTableAdapters.FacultiesTableAdapter();
            this.facultiesTableAdapter1 = new AssignmentDB_Project.AssignmentDBDataSet1TableAdapters.FacultiesTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1298, 63);
            this.panel4.TabIndex = 18;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("League Spartan", 25.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(99, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1234, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 63);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnHideFK);
            this.panel3.Controls.Add(this.btnShowFK);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Location = new System.Drawing.Point(333, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(965, 488);
            this.panel3.TabIndex = 20;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Goldenrod;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(351, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 34);
            this.label9.TabIndex = 26;
            this.label9.Text = "Student List";
            // 
            // btnHideFK
            // 
            this.btnHideFK.BackColor = System.Drawing.Color.Green;
            this.btnHideFK.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHideFK.ForeColor = System.Drawing.Color.White;
            this.btnHideFK.Location = new System.Drawing.Point(836, 439);
            this.btnHideFK.Name = "btnHideFK";
            this.btnHideFK.Size = new System.Drawing.Size(117, 35);
            this.btnHideFK.TabIndex = 24;
            this.btnHideFK.Text = "Hide FK";
            this.btnHideFK.UseVisualStyleBackColor = false;
            this.btnHideFK.Click += new System.EventHandler(this.btnHideFK_Click);
            // 
            // btnShowFK
            // 
            this.btnShowFK.BackColor = System.Drawing.Color.Green;
            this.btnShowFK.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShowFK.ForeColor = System.Drawing.Color.White;
            this.btnShowFK.Location = new System.Drawing.Point(718, 438);
            this.btnShowFK.Name = "btnShowFK";
            this.btnShowFK.Size = new System.Drawing.Size(112, 35);
            this.btnShowFK.TabIndex = 23;
            this.btnShowFK.Text = "Show FK";
            this.btnShowFK.UseVisualStyleBackColor = false;
            this.btnShowFK.Click += new System.EventHandler(this.btnShowFK_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Green;
            this.btnEdit.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(391, 444);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(882, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 35);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(599, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 29);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.Section,
            this.EmailAddress,
            this.ContactNo,
            this.Remarks,
            this.FacultyId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("League Spartan", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(5, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(948, 344);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.FillWeight = 93F;
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            // 
            // Section
            // 
            this.Section.DataPropertyName = "Section";
            this.Section.FillWeight = 60F;
            this.Section.HeaderText = "Section";
            this.Section.Name = "Section";
            // 
            // EmailAddress
            // 
            this.EmailAddress.DataPropertyName = "EmailAddress";
            this.EmailAddress.HeaderText = "EmailAddress";
            this.EmailAddress.Name = "EmailAddress";
            // 
            // ContactNo
            // 
            this.ContactNo.DataPropertyName = "ContactNo";
            this.ContactNo.FillWeight = 85F;
            this.ContactNo.HeaderText = "ContactNo";
            this.ContactNo.Name = "ContactNo";
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.FillWeight = 66F;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            // 
            // FacultyId
            // 
            this.FacultyId.DataPropertyName = "FacultyId";
            this.FacultyId.FillWeight = 80F;
            this.FacultyId.HeaderText = "FacultyId";
            this.FacultyId.Name = "FacultyId";
            this.FacultyId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FacultyId.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Green;
            this.btnNew.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(181, 457);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 32);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Green;
            this.btnReset.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(260, 455);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.txtStudentId.Location = new System.Drawing.Point(116, 129);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(115, 26);
            this.txtStudentId.TabIndex = 7;
            this.txtStudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(17, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.txtStudentName.Location = new System.Drawing.Point(70, 192);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(236, 26);
            this.txtStudentName.TabIndex = 6;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(132, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.cmbFaculty);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtEmailAddress);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.txtRemarks);
            this.panel2.Controls.Add(this.txtContactNo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.txtStudentId);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtSection);
            this.panel2.Controls.Add(this.txtStudentName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-9, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 504);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.facultiesBindingSource1, "FacultyName", true));
            this.cmbFaculty.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facultiesBindingSource, "FacultyId", true));
            this.cmbFaculty.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(70, 418);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(236, 26);
            this.cmbFaculty.TabIndex = 23;
            this.cmbFaculty.Text = "      ";
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // facultiesBindingSource1
            // 
            this.facultiesBindingSource1.DataMember = "Faculties";
            this.facultiesBindingSource1.DataSource = this.assignmentDBDataSet1;
            // 
            // assignmentDBDataSet1
            // 
            this.assignmentDBDataSet1.DataSetName = "AssignmentDBDataSet1";
            this.assignmentDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.assignmentDBDataSet;
            // 
            // assignmentDBDataSet
            // 
            this.assignmentDBDataSet.DataSetName = "AssignmentDBDataSet";
            this.assignmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Goldenrod;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 30);
            this.label10.TabIndex = 25;
            this.label10.Text = "Create A New Student";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(132, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Faculty";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.txtEmailAddress.Location = new System.Drawing.Point(26, 310);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(292, 26);
            this.txtEmailAddress.TabIndex = 17;
            this.txtEmailAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.txtRemarks.Location = new System.Drawing.Point(168, 364);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(150, 26);
            this.txtRemarks.TabIndex = 15;
            this.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.txtContactNo.Location = new System.Drawing.Point(26, 364);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(120, 26);
            this.txtContactNo.TabIndex = 16;
            this.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(174, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Remarks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(109, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "ContactNo";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(95, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSection
            // 
            this.txtSection.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.txtSection.Location = new System.Drawing.Point(117, 248);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(115, 26);
            this.txtSection.TabIndex = 5;
            this.txtSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // facultiesTableAdapter1
            // 
            this.facultiesTableAdapter1.ClearBeforeFill = true;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 525);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private AssignmentDBDataSet assignmentDBDataSet;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private AssignmentDBDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private AssignmentDBDataSet1 assignmentDBDataSet1;
        private System.Windows.Forms.BindingSource facultiesBindingSource1;
        private AssignmentDBDataSet1TableAdapters.FacultiesTableAdapter facultiesTableAdapter1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Section;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyId;
        private System.Windows.Forms.Button btnShowFK;
        private System.Windows.Forms.Button btnHideFK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}