using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecceptHanteringGrupp
{
    public partial class LoginForm : Form
    {
        string filepath = @".\loginCredentials.txt";
        public LoginForm()
        {
            InitializeComponent();
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserAccount = txtUsername + "," + txtPassword;
            string row = "";

            using (StreamReader reader = new StreamReader(filepath))
            {
                if ((row = reader.ReadLine()) != null )
                {

                }
            }
        }


    }
}
