using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly DataContext _context;
        public AnimalRepository(DataContext context)
        {
            _context = context;
        }
        public Task<Animal> MakeAnimal(Animal newAnimal)
        {
            _context.Animals.Add(newAnimal);
            _context.SaveChanges();

            return newAnimal;

        }
    }
}