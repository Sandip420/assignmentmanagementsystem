namespace AssignmentDB_Project
{
    partial class Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assignment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAssignmentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datetimeSubmission = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHideFK = new System.Windows.Forms.Button();
            this.btnShowFK = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TeacherSearch = new System.Windows.Forms.TextBox();
            this.dtAssignment = new System.Windows.Forms.DataGridView();
            this.AssignmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofSubmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSearch = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.StatusSearch = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAssignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.txtComment.Location = new System.Drawing.Point(192, 379);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(154, 26);
            this.txtComment.TabIndex = 15;
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(212, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Comment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Status";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Green;
            this.btnReset.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(265, 417);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.cmbSubject);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cmbTeacher);
            this.panel2.Controls.Add(this.cmbStudent);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtAssignmentId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.datetimeSubmission);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtComment);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 484);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(52, 257);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(226, 26);
            this.cmbSubject.TabIndex = 36;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged_2);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(3, 379);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(174, 26);
            this.cmbStatus.TabIndex = 35;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Goldenrod;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 30);
            this.label10.TabIndex = 34;
            this.label10.Text = "Create A New Assignment";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(54, 131);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(226, 26);
            this.cmbTeacher.TabIndex = 32;
            // 
            // cmbStudent
            // 
            this.cmbStudent.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(54, 194);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(226, 26);
            this.cmbStudent.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Date Of Submission";
            // 
            // txtAssignmentId
            // 
            this.txtAssignmentId.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.txtAssignmentId.Location = new System.Drawing.Point(93, 70);
            this.txtAssignmentId.Name = "txtAssignmentId";
            this.txtAssignmentId.Size = new System.Drawing.Size(130, 26);
            this.txtAssignmentId.TabIndex = 28;
            this.txtAssignmentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 29;
            this.label3.Text = "Assignment Id";
            // 
            // datetimeSubmission
            // 
            this.datetimeSubmission.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.datetimeSubmission.Location = new System.Drawing.Point(12, 320);
            this.datetimeSubmission.Name = "datetimeSubmission";
            this.datetimeSubmission.Size = new System.Drawing.Size(324, 26);
            this.datetimeSubmission.TabIndex = 27;
            this.datetimeSubmission.ValueChanged += new System.EventHandler(this.datetimeSubmission_ValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Green;
            this.btnNew.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(183, 417);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 35);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(119, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(130, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Subject";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(93, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 35);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(12, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student";
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
            this.panel4.TabIndex = 21;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("League Spartan", 25.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(109, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "Assignment";
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.StatusSearch);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.StudentSearch);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnHideFK);
            this.panel3.Controls.Add(this.btnShowFK);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.TeacherSearch);
            this.panel3.Controls.Add(this.dtAssignment);
            this.panel3.Location = new System.Drawing.Point(352, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 476);
            this.panel3.TabIndex = 23;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Goldenrod;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(311, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 34);
            this.label8.TabIndex = 35;
            this.label8.Text = "Assignment List";
            // 
            // btnHideFK
            // 
            this.btnHideFK.BackColor = System.Drawing.Color.Green;
            this.btnHideFK.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHideFK.ForeColor = System.Drawing.Color.White;
            this.btnHideFK.Location = new System.Drawing.Point(818, 422);
            this.btnHideFK.Name = "btnHideFK";
            this.btnHideFK.Size = new System.Drawing.Size(117, 35);
            this.btnHideFK.TabIndex = 27;
            this.btnHideFK.Text = "Hide FK";
            this.btnHideFK.UseVisualStyleBackColor = false;
            this.btnHideFK.Click += new System.EventHandler(this.btnHideFK_Click);
            // 
            // btnShowFK
            // 
            this.btnShowFK.BackColor = System.Drawing.Color.Green;
            this.btnShowFK.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnShowFK.ForeColor = System.Drawing.Color.White;
            this.btnShowFK.Location = new System.Drawing.Point(700, 424);
            this.btnShowFK.Name = "btnShowFK";
            this.btnShowFK.Size = new System.Drawing.Size(112, 35);
            this.btnShowFK.TabIndex = 26;
            this.btnShowFK.Text = "Show FK";
            this.btnShowFK.UseVisualStyleBackColor = false;
            this.btnShowFK.Click += new System.EventHandler(this.btnShowFK_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Green;
            this.btnEdit.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(423, 424);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(885, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 35);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // TeacherSearch
            // 
            this.TeacherSearch.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.TeacherSearch.Location = new System.Drawing.Point(323, 65);
            this.TeacherSearch.Name = "TeacherSearch";
            this.TeacherSearch.Size = new System.Drawing.Size(249, 29);
            this.TeacherSearch.TabIndex = 24;
            this.TeacherSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TeacherSearch.FontChanged += new System.EventHandler(this.txtSearch_FontChanged);
            this.TeacherSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.TeacherSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.TeacherSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // dtAssignment
            // 
            this.dtAssignment.AllowUserToOrderColumns = true;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dtAssignment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dtAssignment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAssignment.BackgroundColor = System.Drawing.Color.White;
            this.dtAssignment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtAssignment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("League Spartan", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtAssignment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dtAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAssignment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentId,
            this.TeacherId,
            this.StudentId,
            this.SubjectId,
            this.StatusId,
            this.Teacher,
            this.Student,
            this.Subject,
            this.Status,
            this.DateofSubmission,
            this.Comment});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("League Spartan", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtAssignment.DefaultCellStyle = dataGridViewCellStyle21;
            this.dtAssignment.EnableHeadersVisualStyles = false;
            this.dtAssignment.Location = new System.Drawing.Point(8, 106);
            this.dtAssignment.Name = "dtAssignment";
            this.dtAssignment.RowTemplate.Height = 25;
            this.dtAssignment.Size = new System.Drawing.Size(935, 306);
            this.dtAssignment.TabIndex = 13;
            this.dtAssignment.DoubleClick += new System.EventHandler(this.dtAssignment_DoubleClick);
            // 
            // AssignmentId
            // 
            this.AssignmentId.DataPropertyName = "AssignmentId";
            this.AssignmentId.HeaderText = "Assignment Id";
            this.AssignmentId.Name = "AssignmentId";
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "TeacherId";
            this.TeacherId.HeaderText = "Teacher Id";
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.Visible = false;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "Student Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.Visible = false;
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "SubjectId";
            this.SubjectId.HeaderText = "Subject Id";
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.Visible = false;
            // 
            // StatusId
            // 
            this.StatusId.DataPropertyName = "StatusId";
            this.StatusId.HeaderText = "Status Id";
            this.StatusId.Name = "StatusId";
            this.StatusId.Visible = false;
            // 
            // Teacher
            // 
            this.Teacher.DataPropertyName = "Teacher";
            this.Teacher.HeaderText = "Teacher";
            this.Teacher.Name = "Teacher";
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // DateofSubmission
            // 
            this.DateofSubmission.DataPropertyName = "DateofSubmission";
            this.DateofSubmission.HeaderText = "Date Of Submission";
            this.DateofSubmission.Name = "DateofSubmission";
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            // 
            // StudentSearch
            // 
            this.StudentSearch.Font = new System.Drawing.Font("League Spartan", 10.2F, System.Drawing.FontStyle.Bold);
            this.StudentSearch.Location = new System.Drawing.Point(8, 65);
            this.StudentSearch.Name = "StudentSearch";
            this.StudentSearch.Size = new System.Drawing.Size(249, 29);
            this.StudentSearch.TabIndex = 37;
            this.StudentSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StudentSearch.Enter += new System.EventHandler(this.StudentSearch_Enter);
            this.StudentSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StudentSearch_KeyUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(256, 65);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(61, 35);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(578, 65);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 35);
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // StatusSearch
            // 
            this.StatusSearch.Font = new System.Drawing.Font("League Spartan", 9F, System.Drawing.FontStyle.Bold);
            this.StatusSearch.FormattingEnabled = true;
            this.StatusSearch.Location = new System.Drawing.Point(705, 65);
            this.StatusSearch.Name = "StatusSearch";
            this.StatusSearch.Size = new System.Drawing.Size(174, 26);
            this.StatusSearch.TabIndex = 40;
            this.StatusSearch.SelectedIndexChanged += new System.EventHandler(this.StatusSearch_SelectedIndexChanged);
            this.StatusSearch.Enter += new System.EventHandler(this.StatusSearch_Enter);
            this.StatusSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StatusSearch_KeyUp);
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Assignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.Assignment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAssignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtAssignment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAssignmentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetimeSubmission;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Button btnHideFK;
        private System.Windows.Forms.Button btnShowFK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofSubmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.TextBox StudentSearch;
        private System.Windows.Forms.TextBox TeacherSearch;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox StatusSearch;
    }
}