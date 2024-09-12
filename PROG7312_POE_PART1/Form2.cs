using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace PROG7312_POE_PART1
{
    public partial class Form2 : Form
    {
        // Variable private declarations
        //this code was taken from: https://www.tutorialspoint.com/private-variables-in-chash
        //Karthikeya Boyini
        private string attachedFileName;
        private const int TotalFields = 4;
        private int completedFields = 0;

        public Form2()
        {
            InitializeComponent();
            ComboBoxInitialization();
            // Initializing methods and components
            //this code was taken from: https://stackoverflow.com/questions/245825/what-does-initializecomponent-do-and-how-does-it-work-in-wpf
            //Danny Beckett
        }
        private void ComboBoxInitialization()
        {
            string[] MunicipalServices = { "Sanitation", "Roads", "Utilities" };

            // Clear existing items to avoid duplicates
            SelectCategoryCombo.Items.Clear();

            // Add "Select Category" as the default option
            SelectCategoryCombo.Items.Add("Select Category");

            // Add other municipal services
            SelectCategoryCombo.Items.AddRange(MunicipalServices);

            // Display "Select Category" as the default option
            SelectCategoryCombo.SelectedIndex = 0;
            SelectCategoryCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void SelectCategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a valid category is selected (not the default "Select Category")
            if (SelectCategoryCombo.SelectedIndex > 0)
            {
                // Category selected, perform necessary actions
                UpdateFormState(); // Assuming this method updates the form state
            }
        }




        private void Locationtxtbox_TextChanged(object sender, EventArgs e)
        {
            // Calling method
            //this method was taken from: https://www.completecsharptutorial.com/basic/calling-method.php
            //Completecsharptutorial
            UpdateFormState();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Calling method
            //this method was taken from: https://www.completecsharptutorial.com/basic/calling-method.php
            //Completecsharptutorial
            UpdateFormState();
        }

  
        private void Locationlabel_Click(object sender, EventArgs e)
        {
            // Calling method
            //this method was taken from: https://www.completecsharptutorial.com/basic/calling-method.php
            //Completecsharptutorial
            UpdateFormState();
        }

        private void Descriptionlabel_Click(object sender, EventArgs e)
        {
            // Calling method
            //this method was taken from: https://www.completecsharptutorial.com/basic/calling-method.php
            //Completecsharptutorial
            UpdateFormState();
        }

        private void Categorylabel_Click(object sender, EventArgs e)
        {
            // Calling method
            //this method was taken from: https://www.completecsharptutorial.com/basic/calling-method.php
            //Completecsharptutorial
            UpdateFormState();
        }

        private void AttachFilebtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf|Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedFileName = openFileDialog.FileName;
                    string fileName = Path.GetFileName(attachedFileName);

                    FileNamelabel.Text = "Attached file: " + fileName;
                    Removebtn.Visible = true;

                    if (IsImageFile(attachedFileName))
                    {
                        pictureBox1.Image = Image.FromFile(attachedFileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Adjust picture box size mode
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }

                    UpdateFormState();
                }
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            // Remove the attached file and UI update
            attachedFileName = null;
            FileNamelabel.Text = "No file attached";
            Removebtn.Visible = false;
            pictureBox1.Image = null;
            UpdateFormState();

            // Update the state of the form


        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            // Hide the current form and show Form1 (main menu)
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            // Display a success message when the form is submitted
            MessageBox.Show("Form has been submitted successfully!");
        }
        private void UpdateFormState()
        {
            // Check if the user has selected a category, attached a file, and filled in the location and description
            //is taken from: https://www.geeksforgeeks.org/c-sharp-isnullorempty-method/
            //Geeksforgeeks
            bool isCategorySelected = SelectCategoryCombo.SelectedIndex > 0;
            bool isFileAttached = !string.IsNullOrEmpty(attachedFileName);
            bool isLocationFilled = !string.IsNullOrEmpty(Locationtxtbox.Text); // Assume location_txtbox is the name of your text box for location
            bool isDescriptionFilled = !string.IsNullOrEmpty(richTextBox1.Text); // Assume description_txtbox is the name of your text box for description

            // Calculate how many fields have been completed
            completedFields = 0;
            if (isLocationFilled) completedFields++;
            if (isDescriptionFilled) completedFields++;
            if (isCategorySelected) completedFields++;
            if (isFileAttached) completedFields++;

            // Update the progress bar based on the completed fields
            //is taken from: https://stackoverflow.com/questions/13440098/how-to-set-value-of-progress-bar
            //user1770370
            progressBar1.Value = completedFields * (progressBar1.Maximum / TotalFields);

            // Show or hide the submit button depending on whether all fields are completed
            //this code was taken from: https://stackoverflow.com/questions/13233451/how-to-show-a-form-again-after-hiding-it
            //Raktim Biswas
            Submitbtn.Visible = completedFields == TotalFields;
        }



        private void progressBar1_Click(object sender, EventArgs e)
        {
            //this code was taken from: https://stackoverflow.com/questions/20624950/void-vs-private-void-in-c-sharp
            //Dai 
            
                // If progress bar is not full, increment it; otherwise, decrement it
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    //calling incrementing method
                    //this method was taken from: https://www.completecsharptutorial.com/basic/calling-method.php
                    //Completecsharptutorial
                    IncrementProgress();
                }
                else
                {
                    //calling decrementing method
                    //this method was taken from: https://www.completecsharptutorial.com/basic/calling-method.php
                    //Completecsharptutorial
                    DecrementProgress();
                }
            }

            private void IncrementProgress()
            {
                // Increase the progress bar value by 25% when a user completes a section of the form
                //is taken from: https://stackoverflow.com/questions/13440098/how-to-set-value-of-progress-bar
                //user1770370
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.Value = Math.Min(progressBar1.Maximum, progressBar1.Value + 25);
                }
            }

            //this code was taken from: https://stackoverflow.com/questions/20624950/void-vs-private-void-in-c-sharp
            //Dai 
            private void DecrementProgress()
            {
                // Decrease the progress bar value by 25% when a user completes a section of the form
                //is taken from: https://stackoverflow.com/questions/13440098/how-to-set-value-of-progress-bar
                //user1770370
                if (progressBar1.Value > progressBar1.Minimum)
                {
                    progressBar1.Value = Math.Max(progressBar1.Minimum, progressBar1.Value - 25);
                }
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(attachedFileName)) return;

            try
            {
                // Attempt to open the file
                Process.Start(new ProcessStartInfo
                {
                    FileName = attachedFileName,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Display an error message if unable to open the file
                MessageBox.Show("Error opening file: " + ex.Message);
            }
        }
            private bool IsImageFile(string fileName)
            {
                // Check if the file extension matches common image formats
                //this code was taken from:  https://www.w3schools.com/cs/cs_arrays.php
                //W3Schools
                string[] imageExtensions = { ".jpg", ".jpeg", ".png" };
                string extension = Path.GetExtension(fileName).ToLower();
                return Array.Exists(imageExtensions, ext => ext == extension);
            }

        private void FileNamelabel_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(attachedFileName)) return;

            //this code was taken from: https://www.w3schools.com/cs/cs_exceptions.php
            //W3Schools
            try
            {
                //Error handling when opening the file

                Process.Start(new ProcessStartInfo
                {
                    FileName = attachedFileName,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                // Display an error message when catch is triggered
                //this code was taken from: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox.show?view=windowsdesktop-8.0
                //Microsoft 
                MessageBox.Show("Error opening file: " + ex.Message);
            }
        }
    }
    }
    
    
