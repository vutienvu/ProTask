using Microsoft.EntityFrameworkCore;
using ProTask.Entity;
using ProTask.Helper;
using ProTask.Request;
using ProTask.Response;
using ProTask.Service.Interface;

namespace ProTask.Service;

public class TodoService : ITodoService
{
    private readonly DatabaseContext _dbContext;
    private readonly DbSet<Todo> _dbSet;
    
    public TodoService(DatabaseContext databaseContext)
    {
        _dbContext = databaseContext;
        _dbSet = _dbContext.Set<Todo>();
    }

    public async Task<TodoResponse> AddAsync(TodoRequest todoRequest)
    {
        Todo todo = new Todo();
        todo.Description = todoRequest.Description;
        todo.Priority = todoRequest.Priority;
        var createdTodo = await _dbSet.AddAsync(todo);
        await _dbContext.SaveChangesAsync();

        TodoResponse todoResponse = new TodoResponse();

        todoResponse.TodoId = createdTodo.Entity.TodoId;
        todoResponse.Description = createdTodo.Entity.Description;
        todoResponse.Priority = createdTodo.Entity.Priority;
        todoResponse.CreatedOn = createdTodo.Entity.CreatedOn;
        todoResponse.ProgrammerId = createdTodo.Entity.ProgrammerId;
        
        return todoResponse;
    }

    public async Task<List<TodoResponse>> GetAllAsync()
    {
        var todos = await _dbSet.ToListAsync();

        List<TodoResponse> resultList = new List<TodoResponse>();
        
        foreach (var todo in todos)
        {
            TodoResponse todoResponse = new TodoResponse();

            todoResponse.TodoId = todo.TodoId;
            todoResponse.Description = todo.Description;
            todoResponse.Priority = todo.Priority;
            todoResponse.CreatedOn = todo.CreatedOn;
            todoResponse.ProgrammerId = todo.ProgrammerId;
            
            resultList.Add(todoResponse);
        }

        return resultList;
    }
}