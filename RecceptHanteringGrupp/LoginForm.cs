using RecceptHanteringGrupp.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RecceptHanteringGrupp
{
    public partial class LoginForm : Form
    {
        FileHandler FileHandler = new FileHandler();

        public LoginForm()
        {
            InitializeComponent();
            lblLoginFailed.Text = "";
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (FileHandler.CheckLoginCredentials(txtUsername.Text, txtPassword.Text))
            {
                //här händer det det som händer om användaren är godkänd
            }
            else
            {
                lblLoginFailed.Text = "Användarnamn eller lösenord är felaktigt";
            }
        }

        
    }
}
