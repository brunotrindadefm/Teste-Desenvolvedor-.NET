using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ILeadService
    {
        Task<IEnumerable<Lead>> GetAllAsync();
        Task<Lead?> GetByIdAsync(int id);
        Task AddAsync(Lead lead);
        Task UpdateAsync(Lead lead);
        Task DeleteAsync(int id);
    }
}
