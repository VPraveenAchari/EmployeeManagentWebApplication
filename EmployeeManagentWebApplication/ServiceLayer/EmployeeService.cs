using EmployeeManagentWebApplication.Models;
using EmployeeManagentWebApplication.Repository.IRepository;
using EmployeeManagentWebApplication.ServiceLayer.IService;

namespace EmployeeManagentWebApplication.ServiceLayer
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployee _emp;
        public EmployeeService(IEmployee emp) 
        {
            _emp = emp;
        }
        public ClientModel CreateClient(ClientModel client)
        {
            var client1 = new ClientModel()
            {
                ClientName = client.ClientName,
                ClientTypeId = client.ClientTypeId,
                ClientAddress = client.ClientAddress,
            };
          return (_emp.CreateClient(client1));
        }

        public EmployeeModel CreateEmployee(EmployeeModel employee)
        {
            var employee1 = new EmployeeModel()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Phone = employee.Phone,
                Address = employee.Address,
                City = employee.City,
                State = employee.State,
                Designation = employee.Designation,
                TechStack = employee.TechStack,
                ReportingManager = employee.ReportingManager,
                CompanyId = employee.CompanyId,
            };
            return(_emp.CreateEmployee(employee1));
        }

       

        public ProjectModel CreateProjects(ProjectModel project)
        {
            var project1 = new ProjectModel()
            {
                ProjectName = project.ProjectName,
                ProjectManager = project.ProjectManager,
                ClientId = project.ClientId

            };
            return (_emp.CreateProjects(project1));
        }
       
        public ProjectResourceMappingModel CreateProjectResourceMapping(ProjectResourceMappingModel projectResourceMapping)
        {
            var projects = new ProjectResourceMappingModel()
            {
                ProjectId = projectResourceMapping.ProjectId,
                EmployeeId = projectResourceMapping.EmployeeId
            };
            return (_emp.CreateProjectResourceMapping(projects));
        }
        

        public ClientModel UpdateClient(ClientModel client, int id)
        {
            return (_emp.UpdateClient(client, id));
        }

        public EmployeeModel UpdateEmployee(EmployeeModel employee, int id)
        {
            return (_emp.UpdateEmployee(employee, id));
        }

        public ProjectModel UpdateProject(ProjectModel project, int id)
        {
            return (_emp.UpdateProject(project, id));
        }
    }
}
