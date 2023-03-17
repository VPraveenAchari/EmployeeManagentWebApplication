using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagentWebApplication.Models
{
    public class ClientModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        [ForeignKey("ClientType")]
        public int ClientTypeId { get; set; }
        public string ClientAddress { get; set; }
    }
}
