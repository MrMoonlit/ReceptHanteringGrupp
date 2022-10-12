namespace RecceptHanteringGrupp.Classes
{
    public static class UserInputHandler
    {
        //Gjorde en snabb generell inputhandler som varnar om användaren missat
        //någon inmatning eller valt kategori som inte finns (vid redigering/nytt recept)
        public static bool MissingInput(Form inForm)
        {
            bool result = false;
            foreach (Control c in inForm.Controls)
            {
                if (c.GetType() == typeof(PictureBox) && c.BackgroundImage == null)
                    result = true;
                if (c.GetType() == typeof(TextBox) && c.Text == null)
                    result = true;
                if (c.GetType() == typeof(ComboBox) && !Recipe.recipeTypes.Contains(c.Text))
                    result = true;
            }
            return result;
        }        
    }
}
