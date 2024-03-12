using System;
using TechExam1.Interface;

namespace TechExam1.Services
{
    public class StringOrganizerService : IStringOrganizerService
    {
        private readonly GetUnique _getUnique;
        private readonly StringHelper _stringHelper;
        public StringOrganizerService(GetUnique getUnique, StringHelper stringHelper)
        {
            _getUnique = getUnique;
            _stringHelper = stringHelper;
        }
        public int GetNumberOfUniqueCharacterFromString(string input)
        {
            _getUnique.characters = _stringHelper.ConvertToListString(input);

            int count =  _getUnique.GetNumberOfUniqueCharacter().Count(); //Remove .ToList() since sa GetNumberOfUniqueCharacter List na ang nirereturn niya

            return count;
        }

       
    }
}
