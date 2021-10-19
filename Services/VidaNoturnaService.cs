using System.Collections.Generic;
using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Data;
using Atividade_Avaliativa_fase_6_front.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade_Avaliativa_fase_6_front.Services
{
    public class VidaNoturnaService
    {
        private readonly ApplicationDbContext _context;
        public VidaNoturnaService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<VidaNoturna>> FindAllAsync()
        {
            return await _context.VidaNoturna.ToListAsync();
        }
    }
}