using System.Xml.Serialization;
namespace RecceptHanteringGrupp.Classes
{
    public class FileHandler
    {
        string _filepath = @".\loginCredentials.txt";
        StreamReader reader = null;

        public bool CheckLoginCredentials(string username, string password)
        {
            try
            {
                using (StreamReader reader = new StreamReader(_filepath))
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


        public static void WriteToFile(Recipe recipe)
        {
            XmlSerializer serializer;
            List<Recipe> recipes;
            recipes = new List<Recipe>();
            serializer = new XmlSerializer(typeof(List <Recipe>));

            
            FileStream filestream = new FileStream("", FileMode.Create, FileAccess.Write);
            
            filestream.Close();
           





        }
    }
}
