using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dtos;
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
        public async Task<IActionResult> MakeAnimal(AnimalCreateDto animalCreateDto)
        {
            Animal newAnimal = new Animal();

            newAnimal.Species = animalCreateDto.Species;
            newAnimal.Color = animalCreateDto.color;

            var createdAnimal= await _repo.MakeAnimal(newAnimal);

            return StatusCode(201);
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimals()
        {
           var yourAnimals = await _repo.GetAnimals();

           return Ok(yourAnimals);
        }
        
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAnimal(int Id)
        {
           Animal yourAnimal = await _repo.GetAnimal(Id);

           return Ok(yourAnimal);
        }
    }
}