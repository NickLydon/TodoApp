using TodoEntities;

namespace TodoApi;

public static class TodoMappingExtensions
{
    public static TodoItem AsTodoItem(this Todo todo)
    {
        return new()
        {
            Id = todo.Id,
            Title = todo.Title,
            IsComplete = todo.IsComplete,
        };
    }
}