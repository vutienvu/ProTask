using ProTask.Request;
using ProTask.Response;

namespace ProTask.Service.Interface;

public interface ITodoService
{
    public Task<TodoResponse> AddAsync(TodoRequest todoRequest);
}