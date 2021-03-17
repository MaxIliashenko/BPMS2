using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BPMS.Components.Service
{
    public interface IAjaxService
    {
        Task<TValue> GetData<TValue>(string requestUri);
    }

    public class AjaxService : IAjaxService
    {
        private readonly HttpClient _http;
        public AjaxService(HttpClient http)
        {
            _http = http;
        }

        public Task<TValue> GetData<TValue>(string requestUri)
        {
            return _http.GetFromJsonAsync<TValue>(requestUri);
        }
    }
}
