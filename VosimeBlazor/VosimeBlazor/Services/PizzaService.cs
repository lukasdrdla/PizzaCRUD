using Microsoft.EntityFrameworkCore;
using VosimeBlazor.Data;
using VosimeBlazor.Models;

namespace VosimeBlazor.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly DataContext _context;
        public PizzaService(DataContext context)
        {
            _context = context;
        }

        public async Task<Pizza> DeletePizza(int id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);
            _context.Pizzas.Remove(pizza);
            _context.SaveChanges();
            return pizza;
        }

        public async Task<Pizza> GetPizzaById(int id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);
            return pizza;
        }

        public async Task<List<Pizza>> GetPizzas()
        {
            var pizzas = await _context.Pizzas.ToListAsync();
            return pizzas;
        }

        public async Task<Pizza> UpdatePizza(int id, Pizza pizza)
        {
            var pizzaToUpdate = await _context.Pizzas.FindAsync(id);
            pizzaToUpdate.Name = pizza.Name;
            pizzaToUpdate.Price = pizza.Price;
            pizzaToUpdate.Description = pizza.Description;
            await _context.SaveChangesAsync();
            return pizzaToUpdate;

        }

        async Task IPizzaService.CreatePizza(Pizza pizza)
        {
           await _context.Pizzas.AddAsync(pizza);
           _context.SaveChanges();
            
        }
    }
}
