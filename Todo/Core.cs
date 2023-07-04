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
                Menu.GetAllTodos();
                var val = ReadValue();
                Console.Clear();
                var result = Menu.GetPageTodo(int.Parse(val));
                if(result > 0)
                {
                    var chouse = ReadValue();
                    if(chouse == "1") 
                    {                       
                        Store.СompleteTodo(int.Parse(val));
                        StartProgram();
                    }
                }
                else
                {
                    Console.ReadKey();
                    StartProgram();
                }
                
            }
            else if (value == "2")
            {
                Console.Clear();
                Menu.GetPageCreate();
                var title = ReadValue();
                Store.Add(new Model.TodoItem { Title = title });
                StartProgram();
            }

        }

        public string ReadValue()
        {
            return Console.ReadLine();
        }
    }
}
