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

            #region Skapar upp recept tillf�lligt f�r att testa funktionalitet
            Recipe recipe1 = new Recipe("Fl�skfile", "Laga maten s� blir det gott att �ta sen", "K�tt", Properties.Resources.flaskfil�gryta_med_champinjoner);
            Recipe recipe2 = new Recipe("Fiskbullar i vitvinss�s", "Laga maten och �r den", "Fisk", Properties.Resources.flaskfil�gryta_med_champinjoner);
            Recipe.recipeList.Add(recipe1);
            Recipe.recipeList.Add(recipe2);
            #endregion

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstSearchResult.Items.Clear();
            var recipeList = Recipe.Search(txtSearchCondition.Text, cboCategory.Text);
            foreach (var recipe in recipeList)
            {
                lstSearchResult.Items.Add(recipe.Name);
            }

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

        private void lstSearchResult_SelectedValueChanged(object sender, EventArgs e)
        {
            //Skickar ut info om valt recept i relevant control

            if (lstSearchResult.SelectedItem != null)
            {
                Recipe result = Recipe.recipeList.Where(recipe => recipe.Name == lstSearchResult.SelectedItem.ToString()).SingleOrDefault();

                lblHeader.Text = result.Name;
                lblType.Text = result.Type;
                txtDescription.Text = result.Description;
                picRecipe.BackgroundImage = result.Picture;
            }


        }
    }
}