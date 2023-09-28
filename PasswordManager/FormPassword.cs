using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
                MessageBox.Show("ERROR! Please input new password!");
            else
            {
                MessageBox.Show("The password has been changed sucessfully!");
            }
                    
        }
    }
}
