using RecceptHanteringGrupp.Classes;
namespace RecceptHanteringGrupp
{
    public partial class SearchForm : Form
    {
        static ChangeForm changeForm = new ChangeForm();

        public SearchForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CheckIfAdmin();
            try
            {
                FileHandler.SetUpResourceFiles();
                Recipe.GetAllRecipes();
            }
            catch (Exception ex)
            {
                FileHandler.LoggingError(ex);
            }

            foreach (string type in Recipe.recipeTypes)
            {
                cboCategory.Items.Add(type);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowSearchResult();
        }

        private void ShowSearchResult()
        {
            lstSearchResult.Items.Clear();
            var recipeList = Recipe.Search(txtSearchCondition.Text, cboCategory.Text);
            foreach (var recipe in recipeList)
            {
                lstSearchResult.Items.Add(recipe.Name);
            }
        }

        private void lblAdminLogin_Click(object sender, EventArgs e)
        {
            if (!LoginForm.loggedIn)
            {
                LoginForm login = new LoginForm();
                login.StartPosition = FormStartPosition.CenterParent;
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Du är redan inloggad");
            }

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
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                btnAddNew.Visible = true;
            }
            else
            {
                btnDelete.Visible = false;
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

            if (HasSelectedRecipe())
            {
                try
                {
                    Recipe result = Recipe.GetSingle(lstSearchResult.SelectedItem.ToString());

                    lblHeader.Text = result.Name;
                    lblType.Text = result.Type;
                    txtDescription.Text = result.Description;
                    picRecipe.BackgroundImage = result.Picture;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (HasSelectedRecipe())
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (HasSelectedRecipe())
            {
                Recipe selected = new Recipe();
                selected = Recipe.GetSingle(lstSearchResult.SelectedItem.ToString());
                Recipe.Remove(selected);
                ShowSearchResult();
            }
            else
            {
                MessageBox.Show("Du måste välja ett recelt att radera.");
            }
        }

        private bool HasSelectedRecipe()
        {
            if (lstSearchResult.SelectedItem == null)
                return false;
            else
                return true;
        }
    }
}