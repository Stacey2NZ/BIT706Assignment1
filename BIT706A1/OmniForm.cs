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
    public partial class OmniForm : Form
    {
        public OmniForm()
        {
            InitializeComponent();
        }

        private void OmniForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string title = "Close Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult = MessageBox.Show(message, title, buttons);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
