using RecceptHanteringGrupp.Classes;
using System.Xml.Serialization;
namespace RecceptHanteringGrupp
{
    public partial class SearchForm : Form
    {
 
        public SearchForm()
        {
            InitializeComponent();
            //en första kommentar
            //Emily första projekt
            //Bara Test




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
            ChangeForm addForm = new ChangeForm();
            addForm.StartPosition = FormStartPosition.Manual;
            addForm.Location = this.Location;
            addForm.Show();
            this.Hide();
        }
    }
}