namespace RecceptHanteringGrupp.Classes
{
    public static class VisualControl
    {

        //Metod för att switcha form
        public static void SwitchForm(Form toForm, Form fromForm)
        { 
            toForm.StartPosition = FormStartPosition.Manual;
            toForm.Location = fromForm.Location;
            toForm.Show();
            fromForm.Hide();
        }
    }


}
