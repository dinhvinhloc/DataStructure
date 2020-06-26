namespace Week6SecA
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAddS1 = new System.Windows.Forms.Button();
            this.btnAddS2 = new System.Windows.Forms.Button();
            this.btnDisplayS1 = new System.Windows.Forms.Button();
            this.btnDisplayS2 = new System.Windows.Forms.Button();
            this.btnCommon = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnRemoveCommon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddSS = new System.Windows.Forms.Button();
            this.btnDisplaySS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(115, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(99, 67);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(48, 20);
            this.txtAge.TabIndex = 3;
            // 
            // btnAddS1
            // 
            this.btnAddS1.Location = new System.Drawing.Point(46, 120);
            this.btnAddS1.Name = "btnAddS1";
            this.btnAddS1.Size = new System.Drawing.Size(75, 23);
            this.btnAddS1.TabIndex = 4;
            this.btnAddS1.Text = "Add S1";
            this.btnAddS1.UseVisualStyleBackColor = true;
            this.btnAddS1.Click += new System.EventHandler(this.btnAddS1_Click);
            // 
            // btnAddS2
            // 
            this.btnAddS2.Location = new System.Drawing.Point(139, 120);
            this.btnAddS2.Name = "btnAddS2";
            this.btnAddS2.Size = new System.Drawing.Size(75, 23);
            this.btnAddS2.TabIndex = 5;
            this.btnAddS2.Text = "Add S2";
            this.btnAddS2.UseVisualStyleBackColor = true;
            this.btnAddS2.Click += new System.EventHandler(this.btnAddS2_Click);
            // 
            // btnDisplayS1
            // 
            this.btnDisplayS1.Location = new System.Drawing.Point(46, 159);
            this.btnDisplayS1.Name = "btnDisplayS1";
            this.btnDisplayS1.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayS1.TabIndex = 6;
            this.btnDisplayS1.Text = "Display S1";
            this.btnDisplayS1.UseVisualStyleBackColor = true;
            this.btnDisplayS1.Click += new System.EventHandler(this.btnDisplayS1_Click);
            // 
            // btnDisplayS2
            // 
            this.btnDisplayS2.Location = new System.Drawing.Point(139, 159);
            this.btnDisplayS2.Name = "btnDisplayS2";
            this.btnDisplayS2.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayS2.TabIndex = 7;
            this.btnDisplayS2.Text = "Display S2";
            this.btnDisplayS2.UseVisualStyleBackColor = true;
            this.btnDisplayS2.Click += new System.EventHandler(this.btnDisplayS2_Click);
            // 
            // btnCommon
            // 
            this.btnCommon.Location = new System.Drawing.Point(46, 209);
            this.btnCommon.Name = "btnCommon";
            this.btnCommon.Size = new System.Drawing.Size(168, 23);
            this.btnCommon.TabIndex = 8;
            this.btnCommon.Text = "Common Elements";
            this.btnCommon.UseVisualStyleBackColor = true;
            this.btnCommon.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(46, 253);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(168, 23);
            this.btnMerge.TabIndex = 9;
            this.btnMerge.Text = "Merged List";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnRemoveCommon
            // 
            this.btnRemoveCommon.Location = new System.Drawing.Point(46, 300);
            this.btnRemoveCommon.Name = "btnRemoveCommon";
            this.btnRemoveCommon.Size = new System.Drawing.Size(168, 23);
            this.btnRemoveCommon.TabIndex = 10;
            this.btnRemoveCommon.Text = "Remove Common Elements";
            this.btnRemoveCommon.UseVisualStyleBackColor = true;
            this.btnRemoveCommon.Click += new System.EventHandler(this.btnRemoveCommon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 283);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnAddSS
            // 
            this.btnAddSS.Location = new System.Drawing.Point(577, 120);
            this.btnAddSS.Name = "btnAddSS";
            this.btnAddSS.Size = new System.Drawing.Size(75, 23);
            this.btnAddSS.TabIndex = 12;
            this.btnAddSS.Text = "Add SS";
            this.btnAddSS.UseVisualStyleBackColor = true;
            // 
            // btnDisplaySS
            // 
            this.btnDisplaySS.Location = new System.Drawing.Point(577, 158);
            this.btnDisplaySS.Name = "btnDisplaySS";
            this.btnDisplaySS.Size = new System.Drawing.Size(75, 23);
            this.btnDisplaySS.TabIndex = 13;
            this.btnDisplaySS.Text = "Display SS";
            this.btnDisplaySS.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 362);
            this.Controls.Add(this.btnDisplaySS);
            this.Controls.Add(this.btnAddSS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRemoveCommon);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnCommon);
            this.Controls.Add(this.btnDisplayS2);
            this.Controls.Add(this.btnDisplayS1);
            this.Controls.Add(this.btnAddS2);
            this.Controls.Add(this.btnAddS1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Use of HashSet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAddS1;
        private System.Windows.Forms.Button btnAddS2;
        private System.Windows.Forms.Button btnDisplayS1;
        private System.Windows.Forms.Button btnDisplayS2;
        private System.Windows.Forms.Button btnCommon;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnRemoveCommon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddSS;
        private System.Windows.Forms.Button btnDisplaySS;
    }
}

