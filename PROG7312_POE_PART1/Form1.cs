using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE_PART1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void ReportIssues_Click_1(object sender, EventArgs e)
        {

            //hide current window and show form 2 
            //this code was taken from: https://stackoverflow.com/questions/13233451/how-to-show-a-form-again-after-hiding-it
            //Raktim Biswas
            this.Hide();

            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Show();
        }

        private void LocalEventsandAnnouncements_Click_1(object sender, EventArgs e)
        {

        }
        private void Service_Request_Status_Click_1(object sender, EventArgs e)
        {

        }


    }
}

   