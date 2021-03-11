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
    public class TaskController : ControllerBase
    {
        private ITaskService _taskService { get; }
        private readonly ILogger<TaskController> _logger;

        public TaskController(ITaskService taskService, ILogger<TaskController> logger)
        {
            _taskService = taskService;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetTaskTree")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<TaskTreeItem>>> GetTaskList() => await _taskService.GetTaskTree();
    }
}
