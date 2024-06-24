using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace ProTask.Entity;

public class Programmer
{
    [Key]
    public int ProgrammerId { get; set; }
    
    [Required]
    [MaxLength(255)]
    public string Name { get; set; } = String.Empty;

    [Required]
    [Range(0, 120)]
    public int Age { get; set; }

    [MaxLength(255)]
    public string Nickname { get; set; } = String.Empty;
}