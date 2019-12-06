using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IAnimalRepository
    {
         Task<Animal> MakeAnimal(Animal newAnimal);
    }
}