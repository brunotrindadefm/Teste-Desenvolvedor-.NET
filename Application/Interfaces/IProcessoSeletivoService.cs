using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProcessoSeletivoService
    {
        Task<IEnumerable<ProcessoSeletivo>> GetAllAsync();
        Task<ProcessoSeletivo?> GetByIdAsync(int id);
        Task AddAsync(ProcessoSeletivo processoSeletivo);
        Task UpdateAsync(ProcessoSeletivo processoSeletivo);
        Task DeleteAsync(int id);
    }
}
