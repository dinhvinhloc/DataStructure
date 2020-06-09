namespace Week4_SecA
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
            this.lblCoachID = new System.Windows.Forms.Label();
            this.lblLoadCapacity = new System.Windows.Forms.Label();
            this.lblCoachType = new System.Windows.Forms.Label();
            this.btbAddAfter = new System.Windows.Forms.Button();
            this.btnAddBefore = new System.Windows.Forms.Button();
            this.btnAddFirst = new System.Windows.Forms.Button();
            this.btnAddLast = new System.Windows.Forms.Button();
            this.txtCoachID = new System.Windows.Forms.TextBox();
            this.txtLoadCapacity = new System.Windows.Forms.TextBox();
            this.txtCoachType = new System.Windows.Forms.TextBox();
            this.txtCoachIDTarget = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnRemoveBefore = new System.Windows.Forms.Button();
            this.btnRemoveAfter = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCoachID
            // 
            this.lblCoachID.AutoSize = true;
            this.lblCoachID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachID.Location = new System.Drawing.Point(69, 78);
            this.lblCoachID.Name = "lblCoachID";
            this.lblCoachID.Size = new System.Drawing.Size(108, 25);
            this.lblCoachID.TabIndex = 0;
            this.lblCoachID.Text = "Coach ID";
            // 
            // lblLoadCapacity
            // 
            this.lblLoadCapacity.AutoSize = true;
            this.lblLoadCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadCapacity.Location = new System.Drawing.Point(69, 151);
            this.lblLoadCapacity.Name = "lblLoadCapacity";
            this.lblLoadCapacity.Size = new System.Drawing.Size(163, 25);
            this.lblLoadCapacity.TabIndex = 1;
            this.lblLoadCapacity.Text = "Load Capacity";
            // 
            // lblCoachType
            // 
            this.lblCoachType.AutoSize = true;
            this.lblCoachType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachType.Location = new System.Drawing.Point(69, 226);
            this.lblCoachType.Name = "lblCoachType";
            this.lblCoachType.Size = new System.Drawing.Size(138, 25);
            this.lblCoachType.TabIndex = 2;
            this.lblCoachType.Text = "Coach Type";
            // 
            // btbAddAfter
            // 
            this.btbAddAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbAddAfter.Location = new System.Drawing.Point(74, 447);
            this.btbAddAfter.Name = "btbAddAfter";
            this.btbAddAfter.Size = new System.Drawing.Size(158, 51);
            this.btbAddAfter.TabIndex = 3;
            this.btbAddAfter.Text = "Add After";
            this.btbAddAfter.UseVisualStyleBackColor = true;
            this.btbAddAfter.Click += new System.EventHandler(this.btbAddAfter_Click);
            // 
            // btnAddBefore
            // 
            this.btnAddBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBefore.Location = new System.Drawing.Point(74, 363);
            this.btnAddBefore.Name = "btnAddBefore";
            this.btnAddBefore.Size = new System.Drawing.Size(158, 51);
            this.btnAddBefore.TabIndex = 4;
            this.btnAddBefore.Text = "Add Before";
            this.btnAddBefore.UseVisualStyleBackColor = true;
            this.btnAddBefore.Click += new System.EventHandler(this.btnAddBefore_Click);
            // 
            // btnAddFirst
            // 
            this.btnAddFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFirst.Location = new System.Drawing.Point(66, 713);
            this.btnAddFirst.Name = "btnAddFirst";
            this.btnAddFirst.Size = new System.Drawing.Size(141, 51);
            this.btnAddFirst.TabIndex = 5;
            this.btnAddFirst.Text = "Add First";
            this.btnAddFirst.UseVisualStyleBackColor = true;
            this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
            // 
            // btnAddLast
            // 
            this.btnAddLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLast.Location = new System.Drawing.Point(253, 713);
            this.btnAddLast.Name = "btnAddLast";
            this.btnAddLast.Size = new System.Drawing.Size(141, 51);
            this.btnAddLast.TabIndex = 5;
            this.btnAddLast.Text = "Add Last";
            this.btnAddLast.UseVisualStyleBackColor = true;
            this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
            // 
            // txtCoachID
            // 
            this.txtCoachID.Location = new System.Drawing.Point(327, 75);
            this.txtCoachID.Name = "txtCoachID";
            this.txtCoachID.Size = new System.Drawing.Size(376, 31);
            this.txtCoachID.TabIndex = 6;
            // 
            // txtLoadCapacity
            // 
            this.txtLoadCapacity.Location = new System.Drawing.Point(327, 148);
            this.txtLoadCapacity.Name = "txtLoadCapacity";
            this.txtLoadCapacity.Size = new System.Drawing.Size(376, 31);
            this.txtLoadCapacity.TabIndex = 7;
            // 
            // txtCoachType
            // 
            this.txtCoachType.Location = new System.Drawing.Point(327, 223);
            this.txtCoachType.Name = "txtCoachType";
            this.txtCoachType.Size = new System.Drawing.Size(376, 31);
            this.txtCoachType.TabIndex = 8;
            // 
            // txtCoachIDTarget
            // 
            this.txtCoachIDTarget.Location = new System.Drawing.Point(327, 363);
            this.txtCoachIDTarget.Name = "txtCoachIDTarget";
            this.txtCoachIDTarget.Size = new System.Drawing.Size(376, 31);
            this.txtCoachIDTarget.TabIndex = 9;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(782, 75);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(893, 611);
            this.dataGridView.TabIndex = 10;
            // 
            // btnRemoveBefore
            // 
            this.btnRemoveBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBefore.Location = new System.Drawing.Point(327, 447);
            this.btnRemoveBefore.Name = "btnRemoveBefore";
            this.btnRemoveBefore.Size = new System.Drawing.Size(218, 51);
            this.btnRemoveBefore.TabIndex = 11;
            this.btnRemoveBefore.Text = "Remove Before";
            this.btnRemoveBefore.UseVisualStyleBackColor = true;
            this.btnRemoveBefore.Click += new System.EventHandler(this.btnRemoveBefore_Click);
            // 
            // btnRemoveAfter
            // 
            this.btnRemoveAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAfter.Location = new System.Drawing.Point(572, 447);
            this.btnRemoveAfter.Name = "btnRemoveAfter";
            this.btnRemoveAfter.Size = new System.Drawing.Size(189, 51);
            this.btnRemoveAfter.TabIndex = 12;
            this.btnRemoveAfter.Text = "Remove After";
            this.btnRemoveAfter.UseVisualStyleBackColor = true;
            this.btnRemoveAfter.Click += new System.EventHandler(this.btnRemoveAfter_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(74, 557);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(158, 51);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(756, 713);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(161, 68);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 793);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRemoveAfter);
            this.Controls.Add(this.btnRemoveBefore);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtCoachIDTarget);
            this.Controls.Add(this.txtCoachType);
            this.Controls.Add(this.txtLoadCapacity);
            this.Controls.Add(this.txtCoachID);
            this.Controls.Add(this.btnAddLast);
            this.Controls.Add(this.btnAddFirst);
            this.Controls.Add(this.btnAddBefore);
            this.Controls.Add(this.btbAddAfter);
            this.Controls.Add(this.lblCoachType);
            this.Controls.Add(this.lblLoadCapacity);
            this.Controls.Add(this.lblCoachID);
            this.Name = "mainForm";
            this.Text = "Coach Management";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoachID;
        private System.Windows.Forms.Label lblLoadCapacity;
        private System.Windows.Forms.Label lblCoachType;
        private System.Windows.Forms.Button btbAddAfter;
        private System.Windows.Forms.Button btnAddBefore;
        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnAddLast;
        private System.Windows.Forms.TextBox txtCoachID;
        private System.Windows.Forms.TextBox txtLoadCapacity;
        private System.Windows.Forms.TextBox txtCoachType;
        private System.Windows.Forms.TextBox txtCoachIDTarget;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRemoveBefore;
        private System.Windows.Forms.Button btnRemoveAfter;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefresh;
    }
}

