using DemoClean.Application.Common.Mappings;
using DemoClean.Domain.Entities;

namespace DemoClean.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
