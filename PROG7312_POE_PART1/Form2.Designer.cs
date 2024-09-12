namespace PROG7312_POE_PART1
{
    partial class Form2
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
            this.Locationtxtbox = new System.Windows.Forms.TextBox();
            this.SelectCategoryCombo = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Locationlabel = new System.Windows.Forms.Label();
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.AttachFilebtn = new System.Windows.Forms.Button();
            this.Removebtn = new System.Windows.Forms.Button();
            this.Menubtn = new System.Windows.Forms.Button();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileNamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Locationtxtbox
            // 
            this.Locationtxtbox.Location = new System.Drawing.Point(29, 69);
            this.Locationtxtbox.Multiline = true;
            this.Locationtxtbox.Name = "Locationtxtbox";
            this.Locationtxtbox.Size = new System.Drawing.Size(276, 128);
            this.Locationtxtbox.TabIndex = 0;
            this.Locationtxtbox.TextChanged += new System.EventHandler(this.Locationtxtbox_TextChanged);
            // 
            // SelectCategoryCombo
            // 
            this.SelectCategoryCombo.FormattingEnabled = true;
            this.SelectCategoryCombo.Location = new System.Drawing.Point(44, 327);
            this.SelectCategoryCombo.Name = "SelectCategoryCombo";
            this.SelectCategoryCombo.Size = new System.Drawing.Size(217, 24);
            this.SelectCategoryCombo.TabIndex = 2;
            this.SelectCategoryCombo.SelectedIndexChanged += new System.EventHandler(this.SelectCategoryCombo_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(491, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 128);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Locationlabel
            // 
            this.Locationlabel.AutoSize = true;
            this.Locationlabel.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.Locationlabel.Location = new System.Drawing.Point(37, 24);
            this.Locationlabel.Name = "Locationlabel";
            this.Locationlabel.Size = new System.Drawing.Size(146, 38);
            this.Locationlabel.TabIndex = 4;
            this.Locationlabel.Text = "Location";
            this.Locationlabel.Click += new System.EventHandler(this.Locationlabel_Click);
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.Descriptionlabel.Location = new System.Drawing.Point(496, 24);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(187, 38);
            this.Descriptionlabel.TabIndex = 5;
            this.Descriptionlabel.Text = "Description";
            this.Descriptionlabel.Click += new System.EventHandler(this.Descriptionlabel_Click);
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.Categorylabel.Location = new System.Drawing.Point(37, 272);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(154, 38);
            this.Categorylabel.TabIndex = 6;
            this.Categorylabel.Text = "Category";
            this.Categorylabel.Click += new System.EventHandler(this.Categorylabel_Click);
            // 
            // AttachFilebtn
            // 
            this.AttachFilebtn.BackColor = System.Drawing.Color.Orange;
            this.AttachFilebtn.Font = new System.Drawing.Font("Arial Black", 14.2F, System.Drawing.FontStyle.Bold);
            this.AttachFilebtn.Location = new System.Drawing.Point(394, 370);
            this.AttachFilebtn.Name = "AttachFilebtn";
            this.AttachFilebtn.Size = new System.Drawing.Size(176, 44);
            this.AttachFilebtn.TabIndex = 7;
            this.AttachFilebtn.Text = "Attach File";
            this.AttachFilebtn.UseVisualStyleBackColor = false;
            this.AttachFilebtn.Click += new System.EventHandler(this.AttachFilebtn_Click);
            // 
            // Removebtn
            // 
            this.Removebtn.BackColor = System.Drawing.Color.Crimson;
            this.Removebtn.Font = new System.Drawing.Font("Arial Black", 14.2F, System.Drawing.FontStyle.Bold);
            this.Removebtn.Location = new System.Drawing.Point(612, 370);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(176, 44);
            this.Removebtn.TabIndex = 8;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = false;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // Menubtn
            // 
            this.Menubtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Menubtn.Font = new System.Drawing.Font("Arial Black", 14.2F, System.Drawing.FontStyle.Bold);
            this.Menubtn.Location = new System.Drawing.Point(29, 470);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(141, 44);
            this.Menubtn.TabIndex = 9;
            this.Menubtn.Text = "Menu";
            this.Menubtn.UseVisualStyleBackColor = false;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // Submitbtn
            // 
            this.Submitbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Submitbtn.Font = new System.Drawing.Font("Arial Black", 14.2F, System.Drawing.FontStyle.Bold);
            this.Submitbtn.Location = new System.Drawing.Point(312, 470);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(141, 44);
            this.Submitbtn.TabIndex = 10;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = false;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-12, -2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(816, 23);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(503, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 98);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FileNamelabel
            // 
            this.FileNamelabel.AutoSize = true;
            this.FileNamelabel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNamelabel.Location = new System.Drawing.Point(526, 200);
            this.FileNamelabel.Name = "FileNamelabel";
            this.FileNamelabel.Size = new System.Drawing.Size(187, 28);
            this.FileNamelabel.TabIndex = 13;
            this.FileNamelabel.Text = "No file attached";
            this.FileNamelabel.Click += new System.EventHandler(this.FileNamelabel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.FileNamelabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.Menubtn);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.AttachFilebtn);
            this.Controls.Add(this.Categorylabel);
            this.Controls.Add(this.Descriptionlabel);
            this.Controls.Add(this.Locationlabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SelectCategoryCombo);
            this.Controls.Add(this.Locationtxtbox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Locationtxtbox;
        private System.Windows.Forms.ComboBox SelectCategoryCombo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Locationlabel;
        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Button AttachFilebtn;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FileNamelabel;
    }
}