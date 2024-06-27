using ProTask.Entity.Enum;

namespace ProTask.Request;

public class TodoRequest
{
    public string Description { get; set; }
    public PriorityEnum Priority { get; set; }
}