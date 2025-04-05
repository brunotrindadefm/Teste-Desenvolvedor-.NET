using Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IInscricaoRepository : IBaseRepository<Inscricao>
    {
        Task<IEnumerable<Inscricao>> GetByCpfAsync(string cpf);
        Task<IEnumerable<Inscricao>> GetByOfertaIdAsync(int id);
        Task<IEnumerable<Inscricao>> GetAllByCpfAsync(string cpf);
    }
}