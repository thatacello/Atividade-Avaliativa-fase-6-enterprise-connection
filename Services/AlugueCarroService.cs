using System.Collections.Generic;
using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Data;
using Atividade_Avaliativa_fase_6_front.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade_Avaliativa_fase_6_front.Services
{
    public class AlugueCarroService
    {
        private readonly ApplicationDbContext _context;
        public AlugueCarroService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<AlugueCarro>> FindAllAsync()
        {
            return await _context.AlugueCarro.ToListAsync();
        }
    }
}