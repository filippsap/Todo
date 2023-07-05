namespace Todo
{
    public class Core
    {
        public Menu Menu { get; set; }

        public Core()
        {
            Menu = new Menu();
        }

        public void StartProgram()
        {
            Console.Clear();
            Menu.GetMainMenu();
            var value = ReadValue();
            if (value == "1")
            {
                TodosOutputScript();
            }
            else if (value == "2")
            {
                TodoCreateScript();
            }

        }

        public void TodosOutputScript()
        {
            Menu.GetAllTodos(Store.Todos);
            var value = ReadValue();
            Console.Clear();
            var todo = Store.Todos.FirstOrDefault(x => x.Id == int.Parse(value));
            if (todo != null)
            {
                Menu.GetPageTodo(todo);
                var chouse = ReadValue();
                if (chouse == "1")
                {
                    Store.СompleteTodo(int.Parse(value));
                    StartProgram();
                }
                else
                {
                    Console.ReadKey();
                    StartProgram();
                }
            }
            else
            {
                Menu.GetNullTodo();
                Console.ReadKey();
                StartProgram();
            }
        }

        public void TodoCreateScript()
        {
            Console.Clear();
            Menu.GetPageCreate();
            var title = ReadValue();
            Store.Add(new Model.TodoItem { Title = title });
            StartProgram();
        }

        public string ReadValue()
        {
            return Console.ReadLine();
        }
    }
}
