using NoobProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoobProject.Interfaces
{
    public interface ILayoutService
    {
        Task<Dictionary<string, string>> GetSettingAsync();
    }
}
