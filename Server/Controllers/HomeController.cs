using BPMS.Shared.Interfaces.Services;
using BPMS.Shared.Layout;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IMenuService _menuService { get; }
        private readonly ILogger<HomeController> _logger;

        public HomeController(IMenuService menuService, ILogger<HomeController> logger)
        {
            _menuService = menuService;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetMenu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<MenuItem>>> GetMenuItems()
            => Ok(_menuService.GetMenuItems());
    }
}
