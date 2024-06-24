using System.ComponentModel.DataAnnotations;
using ProTask.Entity.Enum;

namespace ProTask.Entity;

public class Specialization
{
    [Key]
    public int SpecializationId { get; set; }

    [Required]
    [MaxLength(255)] 
    public string Name { get; set; } = String.Empty;
    
    [Required]
    public SeniorityEnum Seniority { get; set; }
}