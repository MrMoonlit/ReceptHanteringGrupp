using RecceptHanteringGrupp.Classes;
namespace RecceptHanteringGrupp
{
    public partial class SearchForm : Form
    {
        static ChangeForm changeForm = new ChangeForm();

        public SearchForm()
        {
            InitializeComponent();
            CheckIfAdmin();
            Recipe.GetAllRecipes();

            #region Skapar upp recept tillfälligt för att testa funktionalitet

            //Recipe.recipeList.Add(new Recipe("Fläskfile", "Kött", "Såhär lagar du maten:\n\nBörja med att hacka löken... o.s.v..", Properties.Resources.flaskfilégryta_med_champinjoner));
            //Recipe.recipeList.Add(new Recipe("Fiskbullar i vitvinssås", "Fisk", "Såhär lagar du maten:\n\nBörja med att rensa fisken... o.s.v..", Properties.Resources.flaskfilégryta_med_champinjoner));
            //Recipe.recipeList.Add(new Recipe("Kladdkaka", "Desserter/kakor", "Såhär gör du:\n\nBörja med att kladda med ingredienserna... o.s.v..", Properties.Resources.flaskfilégryta_med_champinjoner));
            //Recipe.recipeList.Add(new Recipe("Pekingsoppa", "Soppor", "Såhär lagar du maten:\n\nBörja med koka upp vatten... o.s.v..", Properties.Resources.flaskfilégryta_med_champinjoner));
            //Recipe.recipeList.Add(new Recipe("Cesarsallad", "Sallader", "Såhär lagar du maten:\n\nHacka sallad... o.s.v..", Properties.Resources.flaskfilégryta_med_champinjoner));

            //FileHandler.WriteToFile();
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
            NewRecipeForm newRecipe = new NewRecipeForm();
            VisualControl.SwitchForm(newRecipe, this);
        }

        private void CheckIfAdmin()
        {
            if (LoginForm.loggedIn)
            {
                btnEdit.Visible = true;
                btnAddNew.Visible = true;
            }

            else
            {
                btnEdit.Visible = false;
                btnAddNew.Visible = false;
            }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstSearchResult.SelectedItem != null)
            {
                Recipe selected = new Recipe();
                selected = Recipe.GetSingle(lstSearchResult.SelectedItem.ToString());
                ChangeForm changeForm = new ChangeForm(selected);
                VisualControl.SwitchForm(changeForm, this);
            }
            else
            {
                MessageBox.Show("Du måste välja ett recept i listan att redigera.");

            }
        }
    }
}