using ProTask.Entity.Enum;

namespace ProTask.Response;

public class TodoResponse
{
    public int TodoId { get; set; }
    public string Description { get; set; }
    public PriorityEnum Priority { get; set; }
    public DateTime CreatedOn { get; set; }
    public int? ProgrammerId { get; set; }
}