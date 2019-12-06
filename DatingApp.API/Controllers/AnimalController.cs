using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        public IAnimalRepository _repo;
        public AnimalController(IAnimalRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("makeanimal")]
        public Task<IActionResult> MakeAnimal(string Species, string Color)
        {
            Animal newAnimal = new Animal();

            newAnimal.Species = Species;
            newAnimal.Color = Color;

            var createdAnimal= _repo.MakeAnimal(newAnimal);

            return StatusCode(201);
        }
        
    }
}