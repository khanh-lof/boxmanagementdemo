using DemoClean.Application.TodoLists.Queries.ExportTodos;

namespace DemoClean.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
