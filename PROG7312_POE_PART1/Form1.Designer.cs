namespace PROG7312_POE_PART1
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
            this.ReportIssues = new System.Windows.Forms.Button();
            this.LocalEventsandAnnouncements = new System.Windows.Forms.Button();
            this.Service_Request_Status = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReportIssues
            // 
            this.ReportIssues.BackColor = System.Drawing.Color.Crimson;
            this.ReportIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportIssues.Location = new System.Drawing.Point(297, 85);
            this.ReportIssues.Name = "ReportIssues";
            this.ReportIssues.Size = new System.Drawing.Size(218, 66);
            this.ReportIssues.TabIndex = 0;
            this.ReportIssues.Text = "Report Issues";
            this.ReportIssues.UseVisualStyleBackColor = false;
            this.ReportIssues.Click += new System.EventHandler(this.ReportIssues_Click_1);
            // 
            // LocalEventsandAnnouncements
            // 
            this.LocalEventsandAnnouncements.BackColor = System.Drawing.Color.Orange;
            this.LocalEventsandAnnouncements.CausesValidation = false;
            this.LocalEventsandAnnouncements.Enabled = false;
            this.LocalEventsandAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalEventsandAnnouncements.Location = new System.Drawing.Point(297, 206);
            this.LocalEventsandAnnouncements.Name = "LocalEventsandAnnouncements";
            this.LocalEventsandAnnouncements.Size = new System.Drawing.Size(218, 64);
            this.LocalEventsandAnnouncements.TabIndex = 1;
            this.LocalEventsandAnnouncements.Text = "Local Events and Announcements";
            this.LocalEventsandAnnouncements.UseVisualStyleBackColor = false;
            this.LocalEventsandAnnouncements.Click += new System.EventHandler(this.LocalEventsandAnnouncements_Click_1);
            // 
            // Service_Request_Status
            // 
            this.Service_Request_Status.BackColor = System.Drawing.Color.DodgerBlue;
            this.Service_Request_Status.Enabled = false;
            this.Service_Request_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service_Request_Status.Location = new System.Drawing.Point(297, 332);
            this.Service_Request_Status.Name = "Service_Request_Status";
            this.Service_Request_Status.Size = new System.Drawing.Size(218, 65);
            this.Service_Request_Status.TabIndex = 2;
            this.Service_Request_Status.Text = "Service Request Status";
            this.Service_Request_Status.UseVisualStyleBackColor = false;
            this.Service_Request_Status.Click += new System.EventHandler(this.Service_Request_Status_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Service_Request_Status);
            this.Controls.Add(this.LocalEventsandAnnouncements);
            this.Controls.Add(this.ReportIssues);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReportIssues;
        private System.Windows.Forms.Button LocalEventsandAnnouncements;
        private System.Windows.Forms.Button Service_Request_Status;
        private System.Windows.Forms.Label label1;
    }
}

