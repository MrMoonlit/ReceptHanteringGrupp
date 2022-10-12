namespace RecceptHanteringGrupp.Classes
{
    public static class FileHandler
    {
        //string _filepath = @".\loginCredentials.txt";

        //Lägg till filerna i den färdigdebuggade mappen mitt i smeten med .EXE filen filen så funkar det om det inte redan gör det
        private static string _loginFilepath = Directory.GetCurrentDirectory() + @"\Login_Details.txt";
        private static string _recipesFilePath = Directory.GetCurrentDirectory() + @"\Recipe_Database.txt";

        #region Metoder
        public static bool CheckLoginCredentials(string username, string password)
        {
            try
            {
                using (StreamReader reader = new StreamReader(_loginFilepath))
                {
                    string row = "";

                    if ((row = reader.ReadLine()) != null)
                    {
                        var values = row.Split(',');
                        if (values[0] == username && values[1] == password)
                        {
                            return true;
                        }
                    }
                }
            }
            //felhantering här, för om det inte filepath existerar genereras ett exception. Kastar tillbaka till login-knappen.
            //tänker att vi gör en metod i Filehandler klassen för detta. 
            catch (Exception ex)
            {
                throw ex;
            }            
            return false;
        }


        //en overload som Bara kollar username, för användning vid skapandet av nya användare
        public static bool CheckLoginCredentials(string username)
        {
            try
            {
                using (StreamReader reader = new StreamReader(_loginFilepath))
                {
                    string row = "";

                    if ((row = reader.ReadLine()) != null)
                    {
                        var values = row.Split(',');
                        if (values[0] == username)
                        {
                            return true;
                        }
                    }
                }
            }
            //felhantering här, för om det inte filepath existerar genereras ett exception. Kastar tillbaka till login-knappen.
            //tänker att vi gör en metod i Filehandler klassen för detta. 
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        public static void WriteToFile()
        {
            try
            {
                using (StreamWriter w = new StreamWriter(_recipesFilePath, false))
                {
                    foreach (Recipe recipe in Recipe.recipeList)
                    {
                        string imageConverted = ConvertImageToBase64(recipe.Picture);
                        string concat = recipe.Name + "¤" + recipe.Type + "¤" + recipe.Description + "¤" + imageConverted + "§endObject§";
                        w.WriteLine(concat);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Recipe> ReadFromFile()
        {
            List<Recipe> recipes = new List<Recipe>();
            string recipeFile = File.ReadAllText(_recipesFilePath);

            if (recipeFile != "")
            {
                //Splittar på och bort sista instancen av "§endObject§" som jag använt för att splitta upp objekten.
                int index = recipeFile.LastIndexOf("§endObject§");
                string cleaned = recipeFile.Substring(0, index).TrimEnd();

                //Alla objekt hamnar nu på ett varsitt index i arrayen
                string[] objectArray = cleaned.Split("§endObject§");

                foreach (string line in objectArray)
                {
                    //Splittar upp properties till varsitt index i array
                    string[] lineArray = line.Split("¤");

                    Image recipeImage = ConvertBase64StringToImage(lineArray[3]);
                    Recipe recipe = new Recipe(lineArray[0].TrimStart(), lineArray[1], lineArray[2], recipeImage);
                    recipes.Add(recipe);
                }
            }
            return recipes;
        }



        #region Bildkonvertering för att kunna lagra i textfil
        private static string ConvertImageToBase64(Image imageToConvert)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, imageToConvert.RawFormat);
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Image ConvertBase64StringToImage(string image64Bit)
        {
            byte[] imageBytes = Convert.FromBase64String(image64Bit);
            return new Bitmap(new MemoryStream(imageBytes));
        }
        #endregion
        #endregion
    }
}
