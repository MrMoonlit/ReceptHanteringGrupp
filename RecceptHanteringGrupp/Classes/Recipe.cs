namespace RecceptHanteringGrupp.Classes
{
    public class Recipe
    {

        public static List<Recipe> recipeList = new List<Recipe>();


        public string Name { get; set; }
        public string Type { get; set; } //Kött, Fisk, Sallader, Soppor, Desserter/kakor
        public string Description { get; set; }
        public Image Picture { get; set; } //Path till bilden. Läggs förslagsvis i Properties.Recources (När man skapar upp ett recept anger man alltså image som t.ex: Properties.Resources.flaskfilégryta_med_champinjoner


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


        public static List<Recipe> GetAllRecipes()
        {
            recipeList = FileHandler.ReadFromFile();
            return recipeList;
        }

        public static Recipe GetSingle(string selectedRecipeName)
        {
            Recipe result = recipeList.Where(recipe => recipe.Name == selectedRecipeName).SingleOrDefault();
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
            //Remove(originalRecipe);
            for (int i = 0; i < recipeList.Count; i++)
            {
                if (recipeList[i].Name == originalRecipe.Name)
                {
                    recipeList.RemoveAt(i);
                }
            }
            recipeList.Add(updatedRecipe);
            FileHandler.WriteToFile();
        }

        public static void SaveNew(string name, string description, string type, Image picture)
        {
            Recipe recipe = new Recipe(name, description, type, picture);
            recipeList.Add(recipe);
            FileHandler.WriteToFile();
        }

        public static void Remove(Recipe recipeToRemove)
        {



        }


    }
}
