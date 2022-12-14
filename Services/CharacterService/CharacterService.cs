using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character { Id = 1, Name = "Sam"}
        };

        public async Task<List<Character>> AddCharacters(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int Id)
        {
            return characters.FirstOrDefault(c => c.Id == Id);
        }
    }
}