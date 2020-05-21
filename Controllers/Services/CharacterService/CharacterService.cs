

using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;

namespace dotnet_rpg.Controllers.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

        private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character{
                Id=2,
                Name="sam"
            }
            
        };
        public List<Character> AddCharacter(Character newcharacter)
        {
             characters.Add(newcharacter);
             return characters ;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int Id)
        {
            return characters.FirstOrDefault(c =>c.Id==Id);
        }
    }
}