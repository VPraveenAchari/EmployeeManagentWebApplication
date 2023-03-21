using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EmployeeManagentWebApplication.Models
{
    public class ProjectResourceMappingModel
    {
        [Key]
        public int ProjectResourceMappingId { get; set; }
        [ForeignKey("Projects")]
        public int ProjectId { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
    }
}
