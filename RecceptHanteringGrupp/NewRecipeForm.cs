using RecceptHanteringGrupp.Classes;

namespace RecceptHanteringGrupp
{
    public partial class NewRecipeForm : Form
    {
        SearchForm searchForm = new SearchForm();
        private Image _recipeImage;
        public NewRecipeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Recipe.SaveNew(txtName.Text, cboCategory.Text, txtDescription.Text, _recipeImage);
                MessageBox.Show("Recept sparat!");
                VisualControl.SwitchForm(searchForm, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Något gick fel: " + ex.Message);
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            VisualControl.SwitchForm(searchForm, this);
        }
    }
}
