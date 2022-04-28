using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAppApi.Models
{
    public class Job
    {
        [Key]
        public int? Id { get; set; }

        [Column(TypeName="nvarchar(250)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? Priority { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? Status { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string? CompletionDate { get; set; } 

    }
}
