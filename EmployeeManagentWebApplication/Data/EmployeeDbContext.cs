using EmployeeManagentWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagentWebApplication.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
        {

        }
        public DbSet<CompanyModel> Company { get; set; }
        public DbSet<EmployeeModel> Employee{ get; set; }
        public DbSet<ClientModel> Clients { get; set; }
        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<ProjectResourceMappingModel> ProjectResourceMapping { get; set; }
    }
}
