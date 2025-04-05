using Domain.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class OfertaRepository : BaseRepository<Oferta>, IOfertaRepository
    {
        public OfertaRepository(AppDbContext context) : base(context)
        {
        }
    }
}