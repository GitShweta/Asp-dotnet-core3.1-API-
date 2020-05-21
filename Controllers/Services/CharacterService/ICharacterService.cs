using System.Collections.Generic;
using dotnet_rpg.Models;

namespace dotnet_rpg.Controllers.Services.CharacterService
{
    public interface ICharacterService
    {
        
        List<Character> GetAllCharacters();
        Character GetCharacterById(int Id);

        List<Character> AddCharacter(Character newcharacter);
    }
}