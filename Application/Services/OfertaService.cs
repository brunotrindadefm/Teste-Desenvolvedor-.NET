using Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.Interfaces;
using Application.Interfaces;

namespace Application.Services
{
    public class OfertaService : IOfertaService
    {
        private readonly IOfertaRepository _repository;

        public OfertaService(IOfertaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Oferta>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Oferta?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(Oferta oferta)
        {
            await _repository.AddAsync(oferta);
        }

        public async Task UpdateAsync(Oferta oferta)
        {
            await _repository.UpdateAsync(oferta);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
