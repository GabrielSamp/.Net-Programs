namespace JobTracker
{
    partial class JobTrackerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobTrackerMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblSucess = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblDateApplied = new System.Windows.Forms.Label();
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
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportList = new System.Windows.Forms.Button();
            this.txtExportLocation = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblExportLocation = new System.Windows.Forms.Label();
            this.lblExportFileName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonShowAll = new System.Windows.Forms.RadioButton();
            this.radioButtonThisWeeksJobs = new System.Windows.Forms.RadioButton();
            this.radioButtonLastWeeksJobs = new System.Windows.Forms.RadioButton();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.lblSucess);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCommit);
            this.groupBox1.Controls.Add(this.lblCompany);
            this.groupBox1.Controls.Add(this.lblDateApplied);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Job";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLocation.Location = new System.Drawing.Point(24, 200);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 16;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.Black;
            this.txtLocation.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLocation.Location = new System.Drawing.Point(81, 197);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(318, 20);
            this.txtLocation.TabIndex = 5;
            // 
            // lblSucess
            // 
            this.lblSucess.AutoSize = true;
            this.lblSucess.Location = new System.Drawing.Point(700, 204);
            this.lblSucess.Name = "lblSucess";
            this.lblSucess.Size = new System.Drawing.Size(0, 13);
            this.lblSucess.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(619, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.Crimson;
            this.btnCommit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCommit.Location = new System.Drawing.Point(503, 200);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 7;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCompany.Location = new System.Drawing.Point(24, 70);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 11;
            this.lblCompany.Text = "Company";
            // 
            // lblDateApplied
            // 
            this.lblDateApplied.AutoSize = true;
            this.lblDateApplied.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblDateApplied.Location = new System.Drawing.Point(7, 103);
            this.lblDateApplied.Name = "lblDateApplied";
            this.lblDateApplied.Size = new System.Drawing.Size(68, 13);
            this.lblDateApplied.TabIndex = 10;
            this.lblDateApplied.Text = "Date Applied";
            this.lblDateApplied.Click += new System.EventHandler(this.lblDateApplied_Click);
            // 
            // lblJobNumber
            // 
            this.lblJobNumber.AutoSize = true;
            this.lblJobNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblJobNumber.Location = new System.Drawing.Point(41, 137);
            this.lblJobNumber.Name = "lblJobNumber";
            this.lblJobNumber.Size = new System.Drawing.Size(34, 13);
            this.lblJobNumber.TabIndex = 9;
            this.lblJobNumber.Text = "Job #";
            // 
            // lblAltJobNumber
            // 
            this.lblAltJobNumber.AutoSize = true;
            this.lblAltJobNumber.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblAltJobNumber.Location = new System.Drawing.Point(26, 170);
            this.lblAltJobNumber.Name = "lblAltJobNumber";
            this.lblAltJobNumber.Size = new System.Drawing.Size(49, 13);
            this.lblAltJobNumber.TabIndex = 8;
            this.lblAltJobNumber.Text = "Alt Job #";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(418, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblJob.Location = new System.Drawing.Point(51, 37);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(24, 13);
            this.lblJob.TabIndex = 6;
            this.lblJob.Text = "Job";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Black;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(421, 37);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(436, 146);
            this.txtDescription.TabIndex = 6;
            // 
            // txtDateApplied
            // 
            this.txtDateApplied.BackColor = System.Drawing.Color.Black;
            this.txtDateApplied.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDateApplied.Location = new System.Drawing.Point(81, 100);
            this.txtDateApplied.Name = "txtDateApplied";
            this.txtDateApplied.Size = new System.Drawing.Size(318, 20);
            this.txtDateApplied.TabIndex = 2;
            // 
            // txtAltJobNumber
            // 
            this.txtAltJobNumber.BackColor = System.Drawing.Color.Black;
            this.txtAltJobNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAltJobNumber.Location = new System.Drawing.Point(81, 166);
            this.txtAltJobNumber.Name = "txtAltJobNumber";
            this.txtAltJobNumber.Size = new System.Drawing.Size(318, 20);
            this.txtAltJobNumber.TabIndex = 4;
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.BackColor = System.Drawing.Color.Black;
            this.txtJobNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.txtJobNumber.Location = new System.Drawing.Point(81, 133);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(318, 20);
            this.txtJobNumber.TabIndex = 3;
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.Black;
            this.txtCompany.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCompany.Location = new System.Drawing.Point(81, 67);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(318, 20);
            this.txtCompany.TabIndex = 1;
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.Black;
            this.txtJob.ForeColor = System.Drawing.SystemColors.Window;
            this.txtJob.Location = new System.Drawing.Point(81, 34);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(318, 20);
            this.txtJob.TabIndex = 0;
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.BackColor = System.Drawing.Color.Black;
            this.listViewDisplay.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewDisplay.FullRowSelect = true;
            this.listViewDisplay.GridLines = true;
            this.listViewDisplay.Location = new System.Drawing.Point(12, 289);
            this.listViewDisplay.MultiSelect = false;
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(882, 233);
            this.listViewDisplay.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewDisplay.TabIndex = 9;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            this.listViewDisplay.ItemActivate += new System.EventHandler(this.listViewDisplay_ItemActivate);
            this.listViewDisplay.SelectedIndexChanged += new System.EventHandler(this.listViewDisplay_SelectedIndexChanged);
            this.listViewDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewDisplay_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // btnExportList
            // 
            this.btnExportList.BackColor = System.Drawing.Color.Crimson;
            this.btnExportList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExportList.Location = new System.Drawing.Point(611, 541);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(75, 23);
            this.btnExportList.TabIndex = 12;
            this.btnExportList.Text = "Export";
            this.btnExportList.UseVisualStyleBackColor = false;
            this.btnExportList.Click += new System.EventHandler(this.btnExportList_Click);
            // 
            // txtExportLocation
            // 
            this.txtExportLocation.BackColor = System.Drawing.Color.Black;
            this.txtExportLocation.ForeColor = System.Drawing.SystemColors.Window;
            this.txtExportLocation.Location = new System.Drawing.Point(12, 542);
            this.txtExportLocation.Name = "txtExportLocation";
            this.txtExportLocation.Size = new System.Drawing.Size(257, 20);
            this.txtExportLocation.TabIndex = 9;
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.Black;
            this.txtFileName.ForeColor = System.Drawing.Color.Snow;
            this.txtFileName.Location = new System.Drawing.Point(336, 542);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(260, 20);
            this.txtFileName.TabIndex = 11;
            this.txtFileName.Text = "JobList";
            // 
            // lblExportLocation
            // 
            this.lblExportLocation.AutoSize = true;
            this.lblExportLocation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblExportLocation.Location = new System.Drawing.Point(9, 525);
            this.lblExportLocation.Name = "lblExportLocation";
            this.lblExportLocation.Size = new System.Drawing.Size(81, 13);
            this.lblExportLocation.TabIndex = 5;
            this.lblExportLocation.Text = "Export Location";
            // 
            // lblExportFileName
            // 
            this.lblExportFileName.AutoSize = true;
            this.lblExportFileName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblExportFileName.Location = new System.Drawing.Point(330, 525);
            this.lblExportFileName.Name = "lblExportFileName";
            this.lblExportFileName.Size = new System.Drawing.Size(87, 13);
            this.lblExportFileName.TabIndex = 6;
            this.lblExportFileName.Text = "Export File Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(275, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonShowAll
            // 
            this.radioButtonShowAll.AutoSize = true;
            this.radioButtonShowAll.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radioButtonShowAll.Location = new System.Drawing.Point(313, 266);
            this.radioButtonShowAll.Name = "radioButtonShowAll";
            this.radioButtonShowAll.Size = new System.Drawing.Size(66, 17);
            this.radioButtonShowAll.TabIndex = 13;
            this.radioButtonShowAll.TabStop = true;
            this.radioButtonShowAll.Text = "Show All";
            this.radioButtonShowAll.UseVisualStyleBackColor = true;
            this.radioButtonShowAll.CheckedChanged += new System.EventHandler(this.radioButtonShowAll_CheckedChanged);
            // 
            // radioButtonThisWeeksJobs
            // 
            this.radioButtonThisWeeksJobs.AutoSize = true;
            this.radioButtonThisWeeksJobs.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radioButtonThisWeeksJobs.Location = new System.Drawing.Point(385, 266);
            this.radioButtonThisWeeksJobs.Name = "radioButtonThisWeeksJobs";
            this.radioButtonThisWeeksJobs.Size = new System.Drawing.Size(101, 17);
            this.radioButtonThisWeeksJobs.TabIndex = 14;
            this.radioButtonThisWeeksJobs.TabStop = true;
            this.radioButtonThisWeeksJobs.Text = "This weeks jobs";
            this.radioButtonThisWeeksJobs.UseVisualStyleBackColor = true;
            this.radioButtonThisWeeksJobs.CheckedChanged += new System.EventHandler(this.radioButtonThisWeeksJobs_CheckedChanged);
            // 
            // radioButtonLastWeeksJobs
            // 
            this.radioButtonLastWeeksJobs.AutoSize = true;
            this.radioButtonLastWeeksJobs.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radioButtonLastWeeksJobs.Location = new System.Drawing.Point(492, 266);
            this.radioButtonLastWeeksJobs.Name = "radioButtonLastWeeksJobs";
            this.radioButtonLastWeeksJobs.Size = new System.Drawing.Size(107, 17);
            this.radioButtonLastWeeksJobs.TabIndex = 15;
            this.radioButtonLastWeeksJobs.TabStop = true;
            this.radioButtonLastWeeksJobs.Text = "Last Weeks Jobs";
            this.radioButtonLastWeeksJobs.UseVisualStyleBackColor = true;
            this.radioButtonLastWeeksJobs.CheckedChanged += new System.EventHandler(this.radioButtonLastWeeksJobs_CheckedChanged);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Crimson;
            this.btnImport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImport.Location = new System.Drawing.Point(794, 539);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // JobTrackerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(912, 571);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.radioButtonLastWeeksJobs);
            this.Controls.Add(this.radioButtonThisWeeksJobs);
            this.Controls.Add(this.radioButtonShowAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblExportFileName);
            this.Controls.Add(this.lblExportLocation);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtExportLocation);
            this.Controls.Add(this.btnExportList);
            this.Controls.Add(this.listViewDisplay);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JobTrackerMain";
            this.Text = "Job Tracker 2000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtJob;
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.Button btnExportList;
        private System.Windows.Forms.TextBox txtExportLocation;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblExportLocation;
        private System.Windows.Forms.Label lblExportFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSucess;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.RadioButton radioButtonShowAll;
        private System.Windows.Forms.RadioButton radioButtonThisWeeksJobs;
        private System.Windows.Forms.RadioButton radioButtonLastWeeksJobs;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}

