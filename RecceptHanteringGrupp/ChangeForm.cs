using RecceptHanteringGrupp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecceptHanteringGrupp
{
    public partial class ChangeForm : Form
    {
        SearchForm searchForm = new SearchForm();
        Image recipeImage;
        public ChangeForm()
        {
            InitializeComponent();
            
        }

        private void btnNewImage_Click(object sender, EventArgs e)
        {
            //Öppnar fildialog och användaren klickar på filen den vill ha
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picImage.BackgroundImage = new Bitmap(open.FileName);

                recipeImage = new Bitmap(open.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string test = "";           
            Recipe.SaveNew(txtName.Text, txtDescription.Text, txtType.Text, recipeImage);
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
