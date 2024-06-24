using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProTask.Entity.Enum;

namespace ProTask.Entity;

public class Todo
{
    [Key]
    public int TodoId { get; set; }
    
    [Required]
    [MaxLength(65535)]
    public string Description { get; set; } = String.Empty;
    
    [Required]
    public PriorityEnum Priority { get; set; }

    [Required]
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    
    public Programmer? Programmer { get; set; }
    public int? ProgrammerId { get; set; }
}