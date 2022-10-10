using RecceptHanteringGrupp.Classes;
using System.Xml.Serialization;
namespace RecceptHanteringGrupp
{
    public partial class SearchForm : Form
    {
        static ChangeForm changeForm = new ChangeForm();

        public SearchForm()
        {
            InitializeComponent();
            CheckIfAdmin();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            VisualControl.SwitchForm(changeForm, this);
        }

        private void CheckIfAdmin()
        {
            if (LoginForm.loggedIn)
                btnAddNew.Visible = true;
            else
                btnAddNew.Visible = false;
        }

        private void FormFocusActive(object sender, EventArgs e)
        {
            CheckIfAdmin();
        }
    }
}