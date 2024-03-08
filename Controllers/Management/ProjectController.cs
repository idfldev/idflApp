using idflApp.auth;
using idflApp.Services.management.Projects.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.Management
{
    [ApiController]
    [Route("api/management/project")]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository _repository;
        public ProjectController(IProjectRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Find(){
            var data = _repository.Find();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult GetDetail(Guid id){
            var data = _repository.GetDetailById(id);
            return Ok(data);
        }
    }
}