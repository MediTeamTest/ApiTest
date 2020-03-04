using MediTest.Application.Common.Mappings;
using MediTest.Domain.Entities;

namespace MediTest.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
