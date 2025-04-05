using Application.Interfaces;
using Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.Interfaces;

namespace Application.Services
{
    public class InscricaoService : IInscricaoService
    {
        private readonly IInscricaoRepository _repository;

        public InscricaoService(IInscricaoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Inscricao>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Inscricao?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Inscricao inscricao)
        {
            await _repository.AddAsync(inscricao);
        }

        public async Task UpdateAsync(Inscricao inscricao)
        {
            await _repository.UpdateAsync(inscricao);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Inscricao>> GetByCpfAsync(string cpf)
        {
            return await _repository.GetByCpfAsync(cpf);
        }

        public async Task<IEnumerable<Inscricao>> GetByOfertaIdAsync(int id)
        {
            return await _repository.GetByOfertaIdAsync(id);
        }

        public async Task<IEnumerable<Inscricao>> GetAllByCpfAsync(string cpf)
        {
            return await _repository.GetAllByCpfAsync(cpf);
        }
    }
}
