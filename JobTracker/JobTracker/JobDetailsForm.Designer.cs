namespace JobTracker
{
    partial class JobDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobDetailsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblDateApplied = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblJobNumber = new System.Windows.Forms.Label();
            this.lblAltJobNumber = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDateApplied = new System.Windows.Forms.TextBox();
            this.txtAltJobNumber = new System.Windows.Forms.TextBox();
            this.txtJobNumber = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblCompany);
            this.groupBox1.Controls.Add(this.lblDateApplied);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblJobNumber);
            this.groupBox1.Controls.Add(this.lblAltJobNumber);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblJob);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtDateApplied);
            this.groupBox1.Controls.Add(this.txtAltJobNumber);
            this.groupBox1.Controls.Add(this.txtJobNumber);
            this.groupBox1.Controls.Add(this.txtCompany);
            this.groupBox1.Controls.Add(this.txtJob);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 430);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Job";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLocation.Location = new System.Drawing.Point(24, 192);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.Black;
            this.txtLocation.ForeColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(81, 189);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(318, 20);
            this.txtLocation.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(159, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCompany.Location = new System.Drawing.Point(24, 69);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 11;
            this.lblCompany.Text = "Company";
            // 
            // lblDateApplied
            // 
            this.lblDateApplied.AutoSize = true;
            this.lblDateApplied.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDateApplied.Location = new System.Drawing.Point(7, 100);
            this.lblDateApplied.Name = "lblDateApplied";
            this.lblDateApplied.Size = new System.Drawing.Size(68, 13);
            this.lblDateApplied.TabIndex = 10;
            this.lblDateApplied.Text = "Date Applied";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(240, 401);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.AutoSize = true;
            this.lblJobNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblJobNumber.Location = new System.Drawing.Point(41, 131);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(34, 13);
            this.lblJobNumber.TabIndex = 9;
            this.lblJobNumber.Text = "Job #";
            // 
            // lblAltJobNumber
            // 
            this.lblAltJobNumber.AutoSize = true;
            this.lblAltJobNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAltJobNumber.Location = new System.Drawing.Point(26, 162);
            this.lblAltJobNumber.Name = "lblAltJobNumber";
            this.lblAltJobNumber.Size = new System.Drawing.Size(49, 13);
            this.lblAltJobNumber.TabIndex = 8;
            this.lblAltJobNumber.Text = "Alt Job #";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescription.Location = new System.Drawing.Point(26, 228);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblJob.Location = new System.Drawing.Point(51, 38);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(24, 13);
            this.lblJob.TabIndex = 6;
            this.lblJob.Text = "Job";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(29, 249);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(436, 146);
            this.txtDescription.TabIndex = 6;
            // 
            // txtDateApplied
            // 
            this.txtDateApplied.BackColor = System.Drawing.Color.Black;
            this.txtDateApplied.ForeColor = System.Drawing.Color.White;
            this.txtDateApplied.Location = new System.Drawing.Point(81, 96);
            this.txtDateApplied.Name = "txtDateApplied";
            this.txtDateApplied.Size = new System.Drawing.Size(318, 20);
            this.txtDateApplied.TabIndex = 2;
            // 
            // txtAltJobNumber
            // 
            this.txtAltJobNumber.BackColor = System.Drawing.Color.Black;
            this.txtAltJobNumber.ForeColor = System.Drawing.Color.White;
            this.txtAltJobNumber.Location = new System.Drawing.Point(81, 158);
            this.txtAltJobNumber.Name = "txtAltJobNumber";
            this.txtAltJobNumber.Size = new System.Drawing.Size(318, 20);
            this.txtAltJobNumber.TabIndex = 4;
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.BackColor = System.Drawing.Color.Black;
            this.txtJobNumber.ForeColor = System.Drawing.Color.White;
            this.txtJobNumber.Location = new System.Drawing.Point(81, 127);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(318, 20);
            this.txtJobNumber.TabIndex = 3;
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.Black;
            this.txtCompany.ForeColor = System.Drawing.Color.White;
            this.txtCompany.Location = new System.Drawing.Point(81, 65);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(318, 20);
            this.txtCompany.TabIndex = 1;
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.Black;
            this.txtJob.ForeColor = System.Drawing.Color.White;
            this.txtJob.Location = new System.Drawing.Point(81, 34);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(318, 20);
            this.txtJob.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Crimson;
            this.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.Location = new System.Drawing.Point(371, 448);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Crimson;
            this.btnPrevious.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.Location = new System.Drawing.Point(93, 449);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // JobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(536, 484);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JobDetailsForm";
            this.Text = "JobDetailsForm";
            this.Load += new System.EventHandler(this.JobDetailsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblDateApplied;
        private System.Windows.Forms.Label lblJobNumber;
        private System.Windows.Forms.Label lblAltJobNumber;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDateApplied;
        private System.Windows.Forms.TextBox txtAltJobNumber;
        private System.Windows.Forms.TextBox txtJobNumber;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
    }
}