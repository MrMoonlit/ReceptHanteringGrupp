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

namespace RecceptHanteringGrupp
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void btnNewImage_Click(object sender, EventArgs e)
        {
            //Öppnar ens filer och användaren klickar på filen den vill ha (om det går)
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe(txtName.Text, txtDescription.Text, txtType.Text, picImage.Image);
            FileHandler.WriteToFile(recipe);
        }
    }
}
