using System.Collections.Generic;
using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Data;
using Atividade_Avaliativa_fase_6_front.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade_Avaliativa_fase_6_front.Services
{
    public class GastronomiaService
    {
        private readonly ApplicationDbContext _context;
        public GastronomiaService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Gastronomia>> FindAllAsync()
        {
            return await _context.Gastronomia.ToListAsync();
        }
    }
}