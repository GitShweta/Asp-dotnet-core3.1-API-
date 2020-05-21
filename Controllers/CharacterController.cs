using System.Collections.Generic;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using dotnet_rpg.Controllers.Services.CharacterService;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        
        private readonly ICharacterService _characterservice;

        public CharacterController(ICharacterService characterservice)
        {
            _characterservice=characterservice;
        }

        [HttpGet("GetAll")]
         public IActionResult Get()
         {
             return Ok(_characterservice.GetAllCharacters());
         }
         [HttpGet("{Id}")]
         public IActionResult GetSingle(int id)
         {
             return Ok(_characterservice.GetCharacterById(id));
         }
         [HttpPost]
         public IActionResult AddCharacter(Character newcharacter)
         {
             
             return Ok(_characterservice.AddCharacter(newcharacter));

         }

       
    }
}