using Domain.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace Infrastructure.Repositories
{
    public class InscricaoRepository : BaseRepository<Inscricao>, IInscricaoRepository
    {
        protected readonly AppDbContext _context;
        public InscricaoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Inscricao>> GetByCpfAsync(string cpf)
        {
            return await _context.Inscricao
                .Include(i => i.Lead)
                .Where(i => i.Lead.CPF == cpf)
                .ToListAsync();
        }

        public async Task<IEnumerable<Inscricao>> GetByOfertaIdAsync(int id)
        {
            return await _context.Inscricao
                .Where(i => i.OfertaId == id)
                .ToListAsync();
        }

        public async Task<IEnumerable<Inscricao>> GetAllByCpfAsync(string cpf)
        {
            var fomatCpf = FormatCpf(cpf);

            return await _context.Inscricao
                .Include(i => i.Lead)
                .Include(i => i.Oferta)
                .Include(i => i.ProcessoSeletivo)
                .Where(i => i.Lead.CPF == fomatCpf)
                .ToListAsync();
        }

        private string FormatCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
                return cpf; 

            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
    }
}