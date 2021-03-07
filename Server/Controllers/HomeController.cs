using BPMS.Shared.Interfaces.Services;
using BPMS.Shared.Layout;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BPMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IMenuService _menuService { get; }
        public HomeController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        [Route("GetMenu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<MenuItem>>> GetMenuItems()
            => Ok(_menuService.GetMenuItems());
    }
}
