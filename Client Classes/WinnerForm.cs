using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_App
{
    public partial class WinnerForm : Form
    {
        public WinnerForm()
        {
            InitializeComponent();
        }

        private void MainLabel_Click(object sender, EventArgs e)
        {

        }
        public string LabelText
        {
            get
            {
                return this.MainLabel.Text;
            }
            set
            {
                this.MainLabel.Text = value;
            }
        }

        private void WinnerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
