using Todo.Model;

namespace Todo
{
    public static class Store
    {
        public static List<TodoItem> Todos { get; set; }

        static Store()
        {
            Todos = new List<TodoItem>();
        }

        public static void СompleteTodo(int id)
        {
            var todo = Todos.FirstOrDefault(x => x.Id == id);
            if (todo != null)
            {
                todo.IsDone = true;
            }
        }

        public static void Add(TodoItem item) 
        { 
            item.Id = Todos.Count() + 1;
            Todos.Add(item);
        }

        public static void Remove(TodoItem item)
        { 
            Todos.Remove(item);
        }

        public static void Clear()
        {
            Todos.Clear();
        }

        public static bool Contains(TodoItem item)
        {
            return Todos.Contains(item);
        }

        public static void Loading()
        {

        }
    }
}
