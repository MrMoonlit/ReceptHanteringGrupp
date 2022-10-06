namespace RecceptHanteringGrupp.Classes
{
    public class Recipe
    {
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

        public List<Recipe> Search(string condition, string category)
        {
            //List<Recipe> recipes = FileHandler.GetAllRecipes();

            //var result = recipes.Where(recipe => recipe.Name.Contains(condition) && recipe.Type == category).ToList();

            //return result;
        }

        public void SaveChanges()
        {

        }

        public void SaveNew(string name, string description, string type, Image picture)
        {
            Recipe recipe = new Recipe(name, description, type, picture);
            //FileHandler.WriteToFile();
        }

        private void Delete()
        {

        }

    }
}
