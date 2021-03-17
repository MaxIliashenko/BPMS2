using System.Collections.Generic;
using System.Threading.Tasks;
using BPMS.Shared.Layout;

namespace BPMS.Shared.Interfaces.Services
{
    public interface IHomeService
    {
        Task<List<HomeItem>> GetHomeItems();
    }
}