using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeanASPNETCoreBook.API.Projects
{
    public class TodoService
    {
        private readonly List<TodoItem> _todos = new()
        {
            new TodoItem("Learn C#", false),
            new TodoItem("Build API", true),
        }

        public List<TodoItem> GetTodos() => _todos;
        public void AddTodo(TodoItem item) => _todos.Add(item);
    }


    public record TodoItem(string Task, bool IsCompleted);
}