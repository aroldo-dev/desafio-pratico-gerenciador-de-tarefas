using Microsoft.AspNetCore.Mvc;
using TaskManager.Communication.Interface;
using TaskManager.Communication.Model;
using TaskManager.Communication.Request;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Desafio_pratico_gerenciador_de_tarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRegisterService taskRegisterService;
        private readonly ITaskGetAllService taskGetAllService;
        private readonly ITaskGetService taskGetService;
        private readonly ITaskUpdateService taskUpdateService;
        private readonly ITaskDeleteService taskDeleteService;
        public TaskController(
            ITaskRegisterService taskRegisterService, 
            ITaskGetAllService taskGetAllService,
            ITaskGetService taskGetService,
            ITaskUpdateService taskUpdateService,
            ITaskDeleteService taskDeleteService)
        {
            this.taskRegisterService = taskRegisterService;
            this.taskGetAllService = taskGetAllService;
            this.taskGetService = taskGetService;
            this.taskUpdateService = taskUpdateService;
            this.taskDeleteService = taskDeleteService;

        }

        // GET: api/<TaskController>
        [HttpGet]
        [ProducesResponseType(typeof(List<TMTask>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var TMTasks = this.taskGetAllService.Execute();
            return Ok(TMTasks);
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TMTask), StatusCodes.Status200OK)]
        public IActionResult Get(int id)
        {
            var TMTask = this.taskGetService.Execute(id);
            if(TMTask == null)
            {
                return NotFound();
            }
            return Ok(TMTask);
        }

        // POST api/<TaskController>
        [HttpPost]
        [ProducesResponseType(typeof(TMTask), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] TMTaskJSON task)
        {
            var newTask = taskRegisterService.Execute(task);
            return Created(String.Empty, newTask);
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(TMTask), StatusCodes.Status200OK)]
        public IActionResult Update(int id, [FromBody] TMTaskJSON task)
        {
            var updatedTask = taskUpdateService.Execute(id, task);
            if(updatedTask == null)
            {
                return NotFound();
            }
            return Ok(updatedTask);

        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            var deleted = taskDeleteService.Execute(id);
            if(!deleted)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
