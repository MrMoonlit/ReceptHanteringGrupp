namespace RecceptHanteringGrupp
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            //en f�rsta kommentar
            //Emily f�rsta projekt
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
    }
}