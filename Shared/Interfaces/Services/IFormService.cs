using System.Threading.Tasks;
using BPMS.Shared.Form;

namespace BPMS.Shared.Interfaces.Services
{
    public interface IFormService
    {
        Task<FormData> GetForm(string id);
    }
}
