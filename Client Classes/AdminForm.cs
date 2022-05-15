using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_App
{
    public partial class AdminForm : Form
    {
        Form1 form;
        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(Form1 f)
        {
            this.form = f;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void WarnBtn_Click(object sender, EventArgs e)
        {
           
            BinaryFormatter formatter = new BinaryFormatter();

            ChatAppClasses.Message messageToSend = new ChatAppClasses.Message();

            messageToSend.Type = "Message";
            messageToSend.MessageText = "ADMIN HAS WARNED " + this.AdminBoardUsernameTB.Text;

            formatter.Serialize(form.connection.networkStream, messageToSend);
            form.connection.networkStream.Flush();
        }

        public void setForm(Form1 form)
        {
            this.form = form;
        }
    }
}
