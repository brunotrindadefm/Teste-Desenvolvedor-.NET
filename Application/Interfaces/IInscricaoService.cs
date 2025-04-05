using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IInscricaoService
    {
        Task<IEnumerable<Inscricao>> GetAllAsync();
        Task<Inscricao?> GetByIdAsync(int id);
        Task AddAsync(Inscricao inscricao);
        Task UpdateAsync(Inscricao inscricao);
        Task DeleteAsync(int id);
        Task<IEnumerable<Inscricao>> GetByCpfAsync(string cpf);
        Task<IEnumerable<Inscricao>> GetByOfertaIdAsync(int id);
        Task<IEnumerable<Inscricao>> GetAllByCpfAsync(string cpf);
    }
}
