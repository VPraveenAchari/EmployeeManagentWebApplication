using System.Threading.Tasks;
using EmployeeManagentWebApplication.Data;
using EmployeeManagentWebApplication.Migrations;
using EmployeeManagentWebApplication.Models;
using EmployeeManagentWebApplication.Repository.IRepository;
using EmployeeManagentWebApplication.ServiceLayer;
using EmployeeManagentWebApplication.ServiceLayer.IService;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagentWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employee;
        public EmployeeController(IEmployeeService employee)
        {
            _employee = employee;
        }

        [HttpPost]
        [Route("AddClient")]
        public IActionResult AddClient(ClientModel client)
        {
           var client1= _employee.CreateClient(client);
            return Ok(client1);
        }
        [HttpPut]
        [Route("UpdateClient")]
        public IActionResult UpdateClient(ClientModel client, int id)
        {
            var client1 = _employee.UpdateClient(client, id);
            return Ok(client1);
        }
        [HttpPost]
        [Route("ProjectMapping")]
        public IActionResult AddProjectResourceMapping(ProjectResourceMappingModel projects)
        {
            var project=_employee.CreateProjectResourceMapping(projects);
            return Ok(project);
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(EmployeeModel employeeModel)
        {
            var employee = _employee.CreateEmployee(employeeModel);
            return Ok(employee);
        }
       
        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult UpdateEmployee(EmployeeModel employee, int id)
        {
            var employee1 = _employee.UpdateEmployee(employee, id);
            return Ok(employee1);
        }
        [HttpPost]
        [Route("AddProject")]
        public IActionResult AddProject(ProjectModel project)
        {
            var projects=_employee.CreateProjects(project);
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
            var project1=_employee.CreateProjectResourceMapping(projects);
            return Ok(project1);    
        }
    }
}
