using VosimeBlazor.Models;

namespace VosimeBlazor.Services
{
    public interface IPizzaService
    {
        Task<List<Pizza>> GetPizzas();
        Task<Pizza> GetPizzaById(int id);
        Task CreatePizza(Pizza pizza);
        Task<Pizza> UpdatePizza(int id, Pizza pizza);

        Task<Pizza> DeletePizza(int id);
    }
}
