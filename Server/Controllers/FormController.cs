using BPMS.Shared.Form;
using BPMS.Shared.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BPMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private IFormService _formService { get; }
        private readonly ILogger<FormController> _logger;

        public FormController(IFormService formService, ILogger<FormController> logger)
        {
            _formService = formService;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetForm/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<FormData>> GetFormData(string id) => await _formService.GetForm(id);
    }
}
