using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOfertaService
    {
        Task<IEnumerable<Oferta>> GetAllAsync();
        Task<Oferta?> GetByIdAsync(int id);
        Task AddAsync(Oferta oferta);
        Task UpdateAsync(Oferta oferta);
        Task DeleteAsync(int id);
    }
}
