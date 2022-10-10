using RecceptHanteringGrupp.Classes;
using System.Xml.Serialization;
namespace RecceptHanteringGrupp
{
    public partial class SearchForm : Form
    {
        XmlSerializer serializer;
        List<Recipe> recipes;
        public SearchForm()
        {
            InitializeComponent();
            //en första kommentar
            //Emily första projekt
            //Bara Test
            recipes = new List<Recipe>();
            serializer = new XmlSerializer(typeof(List<Recipe>));




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