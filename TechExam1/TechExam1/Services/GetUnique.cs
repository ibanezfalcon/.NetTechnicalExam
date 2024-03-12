namespace TechExam1.Services
{
    public class GetUnique
    {
        public List<string> characters { get; set; } = new List<string>();
        public List<string> GetNumberOfUniqueCharacter()
        {
            List<string> unique = new List<string>();
            foreach (string character in characters)
            {
                if (CheckIfUnique(character))
                {
                    unique.Add(character);
                }
            }
            return unique;
            
        }
        public bool CheckIfUnique(string character)
        {

            return characters.Count(y => y == character) == 1; // Use LINQ to check the Unique Character
            
        }
    }
}
