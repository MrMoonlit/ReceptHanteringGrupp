namespace RecceptHanteringGrupp.Classes
{
    public class Recipe
    {

        public static List<Recipe> recipeList = new List<Recipe>();


        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } //Kött, Fisk, Sallader, Soppor, Desserter/kakor
        public Image Picture { get; set; } //Path till bilden. Läggs förslagsvis i Properties.Recources (När man skapar upp ett recept anger man alltså image som t.ex: Properties.Resources.flaskfilégryta_med_champinjoner

        public Recipe(string name, string description, string type, Image picture)
        {
            Name = name;
            Description = description;
            Type = type;
            Picture = picture;
        }

        public static List<Recipe> Search(string condition, string category)
        {
            var recipes = new List<Recipe>();

            //Lade denna tillfälligt till en lokal lista. Ska ändras till den lista som läses in från XML-filen
            if (category == "Alla kategorier")
                recipes = recipeList.Where(recipe => recipe.Name.Contains(condition)).ToList();
            else
                recipes = recipeList.Where(recipe => recipe.Name.Contains(condition) && recipe.Type == category).ToList();
            return recipes;
        }

        public void SaveChanges()
        {

        }

        public static void SaveNew(string name, string description, string type, Image picture)
        {
            Recipe recipe = new Recipe(name, description, type, picture);

            //Sparas tillfälligt till lokal lista, ska sparas till XML-fil genom Filehandler-Klassen

            recipeList.Add(recipe);
        }

    }
}
