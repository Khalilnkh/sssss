using Microsoft.EntityFrameworkCore;
using NoobProject.DAL;
using NoobProject.Interfaces;
using NoobProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoobProject.Services
{
    public class LayoutService: ILayoutService
    {
        private readonly AppdbNoob _context;

        public LayoutService(AppdbNoob context)
        {
            _context = context;
        }
        public async Task<Dictionary<string,string>> GetSettingAsync()
        {
            return await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
        }

        
    }
}
