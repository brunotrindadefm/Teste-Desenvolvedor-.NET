using Application.Interfaces;
using Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.Interfaces;

namespace Application.Services
{
    public class LeadService : ILeadService
    {
        private readonly ILeadRepository _repository;

        public LeadService(ILeadRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Lead>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Lead?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Lead lead)
        {
            await _repository.AddAsync(lead);
        }

        public async Task UpdateAsync(Lead lead)
        {
            await _repository.UpdateAsync(lead);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
