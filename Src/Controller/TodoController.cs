using Microsoft.AspNetCore.Mvc;
using ProTask.Helper;
using ProTask.Request;
using ProTask.Service.Interface;

namespace ProTask.Controller;

[ApiController]
[Route("[controller]")]
public class TodoController(ITodoService todoService) : ControllerBase
{
    [HttpPost(Name = "PostTodo")]
    public async Task<IActionResult> AddTodo([FromBody] TodoRequest todoRequest)
    {
        var createdTodo = await todoService.AddAsync(todoRequest);
        return Ok(createdTodo);
    }
}