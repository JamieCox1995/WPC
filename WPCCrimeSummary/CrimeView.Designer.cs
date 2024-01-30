namespace WPCCrimeSummary
{
    partial class CrimeView
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.gbCategorySummary = new System.Windows.Forms.GroupBox();
            this.lvSummary = new System.Windows.Forms.ListView();
            this.gbBreakdown = new System.Windows.Forms.GroupBox();
            this.lvBreakdown = new System.Windows.Forms.ListView();
            this.gbSearch.SuspendLayout();
            this.gbCategorySummary.SuspendLayout();
            this.gbBreakdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.lblMonth);
            this.gbSearch.Controls.Add(this.txtMonth);
            this.gbSearch.Controls.Add(this.lblYear);
            this.gbSearch.Controls.Add(this.txtYear);
            this.gbSearch.Controls.Add(this.txtLongitude);
            this.gbSearch.Controls.Add(this.lblLongitude);
            this.gbSearch.Controls.Add(this.lblLatitude);
            this.gbSearch.Controls.Add(this.txtLatitude);
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(551, 94);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(461, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(392, 25);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(46, 15);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(444, 22);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(92, 23);
            this.txtMonth.TabIndex = 6;
            this.txtMonth.Text = "03";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(253, 25);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 15);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(291, 22);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(92, 23);
            this.txtYear.TabIndex = 4;
            this.txtYear.Text = "2023";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(76, 51);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(150, 23);
            this.txtLongitude.TabIndex = 3;
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(6, 57);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(64, 15);
            this.lblLongitude.TabIndex = 2;
            this.lblLongitude.Text = "Longitude:";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(6, 25);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(53, 15);
            this.lblLatitude.TabIndex = 1;
            this.lblLatitude.Text = "Latitude:";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(76, 22);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(150, 23);
            this.txtLatitude.TabIndex = 0;
            // 
            // gbCategorySummary
            // 
            this.gbCategorySummary.Controls.Add(this.lvSummary);
            this.gbCategorySummary.Location = new System.Drawing.Point(12, 112);
            this.gbCategorySummary.Name = "gbCategorySummary";
            this.gbCategorySummary.Size = new System.Drawing.Size(226, 326);
            this.gbCategorySummary.TabIndex = 1;
            this.gbCategorySummary.TabStop = false;
            this.gbCategorySummary.Text = "Category Summary";
            // 
            // lvSummary
            // 
            this.lvSummary.Location = new System.Drawing.Point(6, 22);
            this.lvSummary.Name = "lvSummary";
            this.lvSummary.Size = new System.Drawing.Size(214, 298);
            this.lvSummary.TabIndex = 0;
            this.lvSummary.UseCompatibleStateImageBehavior = false;
            this.lvSummary.View = System.Windows.Forms.View.List;
            this.lvSummary.SelectedIndexChanged += new System.EventHandler(this.lvSummary_SelectedIndexChanged);
            // 
            // gbBreakdown
            // 
            this.gbBreakdown.Controls.Add(this.lvBreakdown);
            this.gbBreakdown.Location = new System.Drawing.Point(244, 112);
            this.gbBreakdown.Name = "gbBreakdown";
            this.gbBreakdown.Size = new System.Drawing.Size(319, 326);
            this.gbBreakdown.TabIndex = 2;
            this.gbBreakdown.TabStop = false;
            this.gbBreakdown.Text = "Category Breakdown";
            // 
            // lvBreakdown
            // 
            this.lvBreakdown.Location = new System.Drawing.Point(6, 22);
            this.lvBreakdown.Name = "lvBreakdown";
            this.lvBreakdown.Size = new System.Drawing.Size(307, 298);
            this.lvBreakdown.TabIndex = 0;
            this.lvBreakdown.UseCompatibleStateImageBehavior = false;
            this.lvBreakdown.View = System.Windows.Forms.View.List;
            // 
            // CrimeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.gbBreakdown);
            this.Controls.Add(this.gbCategorySummary);
            this.Controls.Add(this.gbSearch);
            this.Name = "CrimeView";
            this.Text = "Crime Summary by Location";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbCategorySummary.ResumeLayout(false);
            this.gbBreakdown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbSearch;
        private TextBox txtLongitude;
        private Label lblLongitude;
        private Label lblLatitude;
        private TextBox txtLatitude;
        private Label lblYear;
        private TextBox txtYear;
        private Label lblMonth;
        private TextBox txtMonth;
        private Button btnSearch;
        private GroupBox gbCategorySummary;
        private ListView lvSummary;
        private GroupBox gbBreakdown;
        private ListView lvBreakdown;
    }
}