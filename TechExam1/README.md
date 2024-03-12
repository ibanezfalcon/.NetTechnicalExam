# TechExam1

You are given a post api that accept string as an input. 
Your task is to optimize the function that counts the number of unique characters in the given string.
Please explain why your solution is much more optimize than the current.
Put your explanations below.

# Note 

If your solution came from ChatGPT you are automatically failed.


# Input:

A string "input" consisting of lowercase and/or uppercase letters and may contain special characters and the string length is n.

# Output:

An integer representing the count of unique characters in the string.

# Example

The given string "pneumonoultramicroscopicsilicovolcanoconiosis" contains 3 unique characters: {'e', 't', 'v'}.

# TestInput

"input" :"Whispers of the Night In the quiet of the moon's embrace, Where shadows dance and secrets trace, The night unfolds its velvet wings, And stars ignite like ancient things. The breeze, a soft and tender kiss, Caresses leaves in whispered bliss, As crickets hum their lullabies, And dreams take flight in moonlit skies. Beneath the silver canopy, The world slows down, and hearts break free, For darkness holds a mystic spell, Where time stands still, and all is well. So close your eyes, my weary friend, And let the night its solace send, For in these hours, we find our grace,And dance with stars in silent space."


# Explanation:
> I remove unecessary async
>In this part
 public int GetNumberOfUniqueCharacterFromString(string input)
 {
     _getUnique.characters = _stringHelper.ConvertToListString(input);

     int count =  _getUnique.GetNumberOfUniqueCharacter().Count(); //Remove .ToList() 

     return count;
 }
 -I remove .ToList since sa GetNumberOfUniqueCharacter List na ang nirereturn niya
 > In this part, I did Use LINQ to check the Unique Character
 public bool CheckIfUnique(string character)
  {
      return characters.Count(y => y == character) == 1; 
  }