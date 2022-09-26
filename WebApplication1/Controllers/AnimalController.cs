using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cadastro_de_doacao.Models;

namespace Cadastro_de_doacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private static List<AnimalModel> animals = new List<AnimalModel> 
            {
                new AnimalModel { 
                    Id = 1,
                    NomeAnimal = "Jimi",
                    RacaAnimal = "gato",
                    DataAdocao = "08/08/2015",
                    NomeTutor = "Paula",
                    TelefoneTutor = "0000000000"
                }
                
            };
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
            return Ok(animals);
        }

        [HttpPost]

        public async Task<ActionResult<List<AnimalModel>>> Post(AnimalModel animal)
        {
            animals.Add(animal);
            return Ok(animals);
        }
    }
}
