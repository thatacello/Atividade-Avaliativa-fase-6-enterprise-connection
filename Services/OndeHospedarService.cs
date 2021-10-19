using System.Collections.Generic;
using System.Threading.Tasks;
using Atividade_Avaliativa_fase_6_front.Data;
using Atividade_Avaliativa_fase_6_front.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade_Avaliativa_fase_6_front.Services
{
    public class OndeHospedarService
    {
        private readonly ApplicationDbContext _context;
        public OndeHospedarService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<OndeHospedar>> FindAllAsync()
        {
            return await _context.OndeHospedar.ToListAsync();
        }
    }
}