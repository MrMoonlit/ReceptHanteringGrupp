namespace RecceptHanteringGrupp.Classes
{
    public class Recipe
    {

        public static List<Recipe> recipeList = new List<Recipe>();
        public static List<string> recipeTypes = new List<string>()
        {
            "Kött", "Fisk", "Sallader", "Soppor", "Desserter/kakor"
        };

        public string Name { get; set; }
        public string Type { get; set; } //Kött, Fisk, Sallader, Soppor, Desserter/kakor
        public string Description { get; set; }
        public Image Picture { get; set; }


        #region Constructors
        public Recipe(string name, string type, string description, Image picture)
        {
            Name = name;
            Type = type;
            Description = description;
            Picture = picture;
        }

        public Recipe()
        {

        }
        #endregion

        #region Methods
        public static List<Recipe> GetAllRecipes()
        {
            recipeList = FileHandler.ReadFromFile();
            return recipeList;
        }

        public static Recipe GetSingle(string selectedRecipeName)
        {
            Recipe result;
            try
            {
                result = recipeList.Where(recipe => recipe.Name == selectedRecipeName).SingleOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static List<Recipe> Search(string condition, string category)
        {
            var recipes = new List<Recipe>();

            if (category == "Alla kategorier")
                recipes = recipeList.Where(recipe => recipe.Name.ToLower().Contains(condition.ToLower())).ToList();
            else
                recipes = recipeList.Where(recipe => recipe.Name.ToLower().Contains(condition.ToLower()) && recipe.Type == category).ToList();
            return recipes;
        }

        public static void SaveChanges(Recipe originalRecipe, Recipe updatedRecipe)
        {
            try
            {
                Remove(originalRecipe);
                recipeList.Add(updatedRecipe);
                FileHandler.WriteToFile();
            }
            catch (Exception ex)
            {
                FileHandler.LoggingError(ex);
                throw;
            }
        }

        public static void SaveNew(string name, string description, string type, Image picture)
        {
            try
            {
                Recipe recipe = new Recipe(name, description, type, picture);
                recipeList.Add(recipe);
                FileHandler.WriteToFile();
            }
            catch (Exception ex)
            {
                FileHandler.LoggingError(ex);
            }
            
        }

        public static void Remove(Recipe recipeToRemove)
        {
            for (int i = 0; i < recipeList.Count; i++)
            {
                if (recipeList[i].Name == recipeToRemove.Name)
                    recipeList.RemoveAt(i);
            }
            FileHandler.WriteToFile();
        }
        public static bool SameRecipeName(string input)
        {
            foreach (Recipe recipe in recipeList)
            {
                if(recipe.Name == input)
                    return true;
            }
            return false;
        }
        #endregion
    }
    
}
