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
    public partial class SettingForm : Form
    {
        Form1 myForm;

        public SettingForm()
        {
            InitializeComponent();
        }
        public SettingForm(Form1 form)
        {
            InitializeComponent();
            myForm = form;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            myForm.IPFromSettings = this.IPAddressTB.Text;
            myForm.portFromSettings = int.Parse(PortTB.Text);
            
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
