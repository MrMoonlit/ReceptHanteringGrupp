using RecceptHanteringGrupp.Classes;

namespace RecceptHanteringGrupp
{
    public partial class ChangeForm : Form
    {
        SearchForm searchForm = new SearchForm();
        private Image _recipeImage;
        private Recipe _originalRecipe;
        public ChangeForm(Recipe originalRecipe)
        {
            InitializeComponent();
            _originalRecipe = originalRecipe;
            txtName.Text = originalRecipe.Name;
            cboCategory.Text = originalRecipe.Type;
            txtDescription.Text = originalRecipe.Description;
            picImage.BackgroundImage = originalRecipe.Picture;
            _recipeImage = originalRecipe.Picture;

            foreach (string type in Recipe.recipeTypes)
            {
                cboCategory.Items.Add(type);
            }
        }
        public ChangeForm()
        {

        }

        private void btnNewImage_Click(object sender, EventArgs e)
        {
            //Öppnar fildialog och användaren klickar på filen den vill ha
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picImage.BackgroundImage = new Bitmap(open.FileName);

                _recipeImage = new Bitmap(open.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Recipe updatedRecipe = new Recipe(txtName.Text, cboCategory.Text, txtDescription.Text, _recipeImage);

            Recipe.SaveChanges(_originalRecipe, updatedRecipe);
            VisualControl.SwitchForm(searchForm, this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            VisualControl.SwitchForm(searchForm, this);
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
