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

            #region Skapar upp recept tillfälligt för att testa funktionalitet
            Recipe recipe1 = new Recipe("Fläskfile", "Laga maten så blir det gott att äta sen", "Kött", Properties.Resources.flaskfilégryta_med_champinjoner);
            Recipe recipe2 = new Recipe("Fiskbullar i vitvinssås", "Laga maten och är den", "Fisk", Properties.Resources.flaskfilégryta_med_champinjoner);
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