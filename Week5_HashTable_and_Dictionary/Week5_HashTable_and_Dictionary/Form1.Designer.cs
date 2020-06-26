namespace Week5_HashTable_and_Dictionary
{
    partial class Form1
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
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseCredit = new System.Windows.Forms.Label();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseCredit = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCode.Location = new System.Drawing.Point(30, 54);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(79, 13);
            this.lblCourseCode.TabIndex = 0;
            this.lblCourseCode.Text = "Course Code";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(30, 93);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(82, 13);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourseCredit
            // 
            this.lblCourseCredit.AutoSize = true;
            this.lblCourseCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCredit.Location = new System.Drawing.Point(30, 133);
            this.lblCourseCredit.Name = "lblCourseCredit";
            this.lblCourseCredit.Size = new System.Drawing.Size(40, 13);
            this.lblCourseCredit.TabIndex = 0;
            this.lblCourseCredit.Text = "Credit";
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Location = new System.Drawing.Point(114, 46);
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(177, 20);
            this.txtCourseCode.TabIndex = 1;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(114, 86);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(177, 20);
            this.txtCourseName.TabIndex = 1;
            // 
            // txtCourseCredit
            // 
            this.txtCourseCredit.Location = new System.Drawing.Point(114, 126);
            this.txtCourseCredit.Name = "txtCourseCredit";
            this.txtCourseCredit.Size = new System.Drawing.Size(177, 20);
            this.txtCourseCredit.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(342, 46);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(419, 260);
            this.dataGridView.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(13, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(94, 282);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(175, 283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(256, 282);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtCourseCredit);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseCode);
            this.Controls.Add(this.lblCourseCredit);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseCode);
            this.Name = "Form1";
            this.Text = "Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseCredit;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseCredit;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
    }
}

