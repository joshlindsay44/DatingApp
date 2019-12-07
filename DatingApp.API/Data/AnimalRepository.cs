using System.Collections.Generic;
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
        public async Task<Animal> MakeAnimal(Animal newAnimal)
        {
            await _context.Animals.AddAsync(newAnimal);
            await _context.SaveChangesAsync();

            return newAnimal;

        }

        public async Task<Animal> GetAnimal(int Id)
        {
            Animal yourAnimal = await _context.Animals.FirstOrDefaultAsync(x => x.Id == Id);
            return yourAnimal;
        }

        public async Task<List<Animal>> GetAnimals()
        {
            List<Animal> yourAnimals = new List<Animal>();
             yourAnimals = await _context.Animals.ToListAsync();
            return yourAnimals;
        }
    }
}