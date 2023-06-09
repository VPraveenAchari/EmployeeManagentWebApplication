﻿using EmployeeManagentWebApplication.Models;

namespace EmployeeManagentWebApplication.Repository.IRepository
{
    public interface IEmployee
    {
        IEnumerable<EmployeeModel> Get();
        ClientModel CreateClient(ClientModel client);
        ClientModel UpdateClient(ClientModel client,int id);
       
        EmployeeModel CreateEmployee(EmployeeModel employee);
        EmployeeModel UpdateEmployee(EmployeeModel employee,int id);
        ProjectModel CreateProjects(ProjectModel project);
        ProjectModel UpdateProject(ProjectModel project,int id);
        ProjectResourceMappingModel CreateProjectResourceMapping(ProjectResourceMappingModel projectResourceMapping);
    }
}
