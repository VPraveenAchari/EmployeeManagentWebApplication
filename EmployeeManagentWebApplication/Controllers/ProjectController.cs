using EmployeeManagentWebApplication.Models;
using EmployeeManagentWebApplication.ServiceLayer.IService;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagentWebApplication.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IEmployeeService _employee;
        public ProjectController(IEmployeeService employee)
        {
            _employee = employee;
        }
        [HttpPost]
        [Route("AddProject")]
        public IActionResult AddProject(ProjectModel project)
        {
            var projects = _employee.CreateProjects(project);
            return Ok(projects);
        }
        [HttpPut]
        [Route("UpdateProject")]
        public IActionResult UpdateProject(ProjectModel project, int id)
        {
            var project1 = _employee.UpdateProject(project, id);
            return Ok(project1);
        }
        [HttpPost]
        [Route("AddProjects")]
        public IActionResult AddProjects(ProjectResourceMappingModel projects)
        {
            var project1 = _employee.CreateProjectResourceMapping(projects);
            return Ok(project1);
        }
    }
}
