using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAnimalRepository
    {
         Task<Animal> MakeAnimal(Animal newAnimal);

         Task<Animal> GetAnimal(int Id);

         Task<List<Animal>> GetAnimals();
    }
}