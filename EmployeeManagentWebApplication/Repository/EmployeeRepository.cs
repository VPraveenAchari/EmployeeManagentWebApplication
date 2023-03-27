using EmployeeManagentWebApplication.Data;
using EmployeeManagentWebApplication.Migrations;
using EmployeeManagentWebApplication.Models;
using EmployeeManagentWebApplication.Repository.IRepository;

namespace EmployeeManagentWebApplication.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeDbContext _emp;
        public EmployeeRepository(EmployeeDbContext emp)
        {
            _emp = emp;
        }
        public ClientModel CreateClient(ClientModel client)
        {
            _emp.Clients.Add(client);
            _emp.SaveChanges();
            return (client);
        }

        public EmployeeModel CreateEmployee(EmployeeModel employee)
        {
            _emp.Employee.Add(employee);
            _emp.SaveChanges();
            return (employee);
        }

        public ProjectResourceMappingModel CreateProjectResourceMapping(ProjectResourceMappingModel projectResourceMapping)
        {
            _emp.ProjectResourceMapping.Add(projectResourceMapping);
            _emp.SaveChanges();
            return (projectResourceMapping);
        }

        public ProjectModel CreateProjects(ProjectModel project)
        {
            _emp.Projects.Add(project);
            _emp.SaveChanges();
            return (project);
        }

        public IEnumerable<EmployeeModel> Get()
        {
            return _emp.Employee.ToList();
        }

        public ClientModel UpdateClient(ClientModel client, int id)
        {
            var client1 = _emp.Clients.FirstOrDefault(x => x.ClientId == id);
            if (client1 != null)
            {
                client1.ClientId = id;
                client1.ClientName = client.ClientName;
                client1.ClientTypeId = client.ClientTypeId;
                client1.ClientAddress = client.ClientAddress;
            };
            _emp.Clients.Update(client1);
            _emp.SaveChanges();
            return (client1);
        }

        public EmployeeModel UpdateEmployee(EmployeeModel employee, int id)
        {
            var employee1=_emp.Employee.FirstOrDefault(x=>x.EmployeeId== id);
            if(employee1 != null)
            {
                employee1.EmployeeId = id;
                employee1.FirstName= employee.FirstName;
                employee1.LastName= employee.LastName;
                employee1.Address = employee.Address;
                employee1.City = employee.City;
                employee1.State= employee.State;
                employee1.ReportingManager = employee.ReportingManager;
                employee1.Designation= employee.Designation;
                employee1.TechStack= employee.TechStack;
            }
            _emp.Employee.Update(employee1);
            _emp.SaveChanges();
            return (employee1);
        }

        public ProjectModel UpdateProject(ProjectModel project, int id)
        {
            var project1=_emp.Projects.FirstOrDefault(x=>x.ProjectId== id);
            if(project1 != null)
            {
                project1.ProjectId = id;
                project1.ProjectName= project.ProjectName;
                project1.ProjectManager = project.ProjectManager;
                project1.ClientId= project.ClientId;
            }
            _emp.Projects.Update(project1);
            _emp.SaveChanges();
            return (project1);
        }
    }
}
