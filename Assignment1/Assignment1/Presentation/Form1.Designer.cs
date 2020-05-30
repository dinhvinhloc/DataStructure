namespace Assignment1
{
    partial class frmMain
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
            this.labelStudentIDInput = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.labelStudentNameInput = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtAssignmentScore = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.txtAssignmentID = new System.Windows.Forms.TextBox();
            this.labelAssignmentID = new System.Windows.Forms.Label();
            this.dataGridAssignment = new System.Windows.Forms.DataGridView();
            this.btnAddAssignment = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignment)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudentIDInput
            // 
            this.labelStudentIDInput.AutoSize = true;
            this.labelStudentIDInput.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentIDInput.Location = new System.Drawing.Point(58, 59);
            this.labelStudentIDInput.Name = "labelStudentIDInput";
            this.labelStudentIDInput.Size = new System.Drawing.Size(118, 30);
            this.labelStudentIDInput.TabIndex = 0;
            this.labelStudentIDInput.Text = "Student ID";
            this.labelStudentIDInput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID.Location = new System.Drawing.Point(194, 56);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(314, 35);
            this.txtStudentID.TabIndex = 1;
            // 
            // labelStudentNameInput
            // 
            this.labelStudentNameInput.AutoSize = true;
            this.labelStudentNameInput.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentNameInput.Location = new System.Drawing.Point(22, 119);
            this.labelStudentNameInput.Name = "labelStudentNameInput";
            this.labelStudentNameInput.Size = new System.Drawing.Size(154, 30);
            this.labelStudentNameInput.TabIndex = 2;
            this.labelStudentNameInput.Text = "Student Name";
            this.labelStudentNameInput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.Location = new System.Drawing.Point(194, 116);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(314, 35);
            this.txtStudentName.TabIndex = 3;
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Location = new System.Drawing.Point(533, 56);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.RowHeadersWidth = 82;
            this.dataGridStudent.RowTemplate.Height = 33;
            this.dataGridStudent.Size = new System.Drawing.Size(992, 266);
            this.dataGridStudent.TabIndex = 4;
            this.dataGridStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudent_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(40, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 53);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(290, 269);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 52);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtAssignmentScore
            // 
            this.txtAssignmentScore.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmentScore.Location = new System.Drawing.Point(194, 467);
            this.txtAssignmentScore.Name = "txtAssignmentScore";
            this.txtAssignmentScore.Size = new System.Drawing.Size(314, 35);
            this.txtAssignmentScore.TabIndex = 10;
            this.txtAssignmentScore.TextChanged += new System.EventHandler(this.txtAssignmentScore_TextChanged);
            this.txtAssignmentScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAssignmentScore_KeyPress);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(109, 470);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(67, 30);
            this.labelScore.TabIndex = 9;
            this.labelScore.Text = "Score";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAssignmentID
            // 
            this.txtAssignmentID.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssignmentID.Location = new System.Drawing.Point(194, 407);
            this.txtAssignmentID.Name = "txtAssignmentID";
            this.txtAssignmentID.Size = new System.Drawing.Size(314, 35);
            this.txtAssignmentID.TabIndex = 8;
            // 
            // labelAssignmentID
            // 
            this.labelAssignmentID.AutoSize = true;
            this.labelAssignmentID.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignmentID.Location = new System.Drawing.Point(19, 412);
            this.labelAssignmentID.Name = "labelAssignmentID";
            this.labelAssignmentID.Size = new System.Drawing.Size(157, 30);
            this.labelAssignmentID.TabIndex = 7;
            this.labelAssignmentID.Text = "Assignment ID";
            this.labelAssignmentID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridAssignment
            // 
            this.dataGridAssignment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAssignment.Location = new System.Drawing.Point(533, 410);
            this.dataGridAssignment.Name = "dataGridAssignment";
            this.dataGridAssignment.RowHeadersWidth = 82;
            this.dataGridAssignment.RowTemplate.Height = 33;
            this.dataGridAssignment.Size = new System.Drawing.Size(992, 242);
            this.dataGridAssignment.TabIndex = 11;
            // 
            // btnAddAssignment
            // 
            this.btnAddAssignment.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssignment.Location = new System.Drawing.Point(40, 599);
            this.btnAddAssignment.Name = "btnAddAssignment";
            this.btnAddAssignment.Size = new System.Drawing.Size(166, 53);
            this.btnAddAssignment.TabIndex = 12;
            this.btnAddAssignment.Text = "Add/Update";
            this.btnAddAssignment.UseVisualStyleBackColor = true;
            this.btnAddAssignment.Click += new System.EventHandler(this.btnAddAssignment_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(528, 382);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 25);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(678, 382);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 25);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 707);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnAddAssignment);
            this.Controls.Add(this.dataGridAssignment);
            this.Controls.Add(this.txtAssignmentScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.txtAssignmentID);
            this.Controls.Add(this.labelAssignmentID);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridStudent);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.labelStudentNameInput);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.labelStudentIDInput);
            this.Name = "frmMain";
            this.Text = "Student\'s Assignment Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAssignment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentIDInput;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label labelStudentNameInput;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtAssignmentScore;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox txtAssignmentID;
        private System.Windows.Forms.Label labelAssignmentID;
        private System.Windows.Forms.DataGridView dataGridAssignment;
        private System.Windows.Forms.Button btnAddAssignment;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
    }
}

