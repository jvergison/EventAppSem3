using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEvents.View
{
    public partial class LoginForm : Form
    {
        Controller controller;

        public string ReturnValue { get; set; } 

        public LoginForm()
        {
            InitializeComponent();
            controller = new Controller();

            this.Text = "Log in ";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //check if user/pw combination is correct in the db

            if (controller.LogIn(UsernameBox.Text, PasswordBox.Text))
            {
                //successfully logged in
                this.ReturnValue = UsernameBox.Text;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                //failed to login, show errors
                errorProvider1.SetError(UsernameBox,"Invalid user name or password");
                errorProvider1.SetError(PasswordBox, "Invalid user name or password");
            }
            
        }
    }
}
