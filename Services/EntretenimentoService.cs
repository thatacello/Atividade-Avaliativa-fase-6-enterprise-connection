using System.Collections.Generic;
using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Data;
using Atividade_Avaliativa_fase_6_front.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade_Avaliativa_fase_6_front.Services
{
    public class EntretenimentoService
    {
        private readonly ApplicationDbContext _context;
        public EntretenimentoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Entretenimento>> FindAllAsync()
        {
            return await _context.Entretenimento.ToListAsync();
        }
    }
}