using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //After creating the forms, I realised that this.close would close the entire application, instead of just the form that was running. After some research
        //I found that I should have created a main form, then run this form from it, so that when I used this.close, it would still have the main form running and the other
        //form being created and shown would actually show. I ran out of time to re-do this, but will incorporate it in future.
        private void everydayBtn_Click(object sender, EventArgs e)
        {
            EverydayForm everydayForm = new EverydayForm();
            everydayForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string title = "Close Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, title, buttons);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void investmentBtn_Click(object sender, EventArgs e)
        {
            InvestmentForm investmentForm = new InvestmentForm();
            investmentForm.Show();
            this.Hide();
        }

        private void omniBtn_Click(object sender, EventArgs e)
        {
            OmniForm omniForm = new OmniForm();
            omniForm.Show();
            this.Hide();
        }
    }
}
