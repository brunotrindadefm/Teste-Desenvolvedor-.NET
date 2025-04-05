using Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.Interfaces;
using Application.Interfaces;

namespace Application.Services
{
    public class ProcessoSeletivoService : IProcessoSeletivoService
    {
        private readonly IProcessoSeletivoRepository _repository;

        public ProcessoSeletivoService(IProcessoSeletivoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProcessoSeletivo>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ProcessoSeletivo?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(ProcessoSeletivo processoSeletivo)
        {
            await _repository.AddAsync(processoSeletivo);
        }

        public async Task UpdateAsync(ProcessoSeletivo processoSeletivo)
        {
            await _repository.UpdateAsync(processoSeletivo);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
