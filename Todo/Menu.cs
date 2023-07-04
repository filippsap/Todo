using Todo.Model;

namespace Todo
{
    public class Menu
    {
        public void GetMainMenu()
        {
            Console.WriteLine("Программа Todo от Филиппа");
            Console.WriteLine("1.Список todos");
            Console.WriteLine("2.Создать todo");
        }

        public void GetAllTodos(IEnumerable<TodoItem> todoItems)
        {
            Console.Clear();
            Console.WriteLine("Список всех задач:");
            foreach (var item in todoItems)
            {
                Console.WriteLine(item.Id + "." + item.Title + " | " + "Состояние: " + (item.IsDone ? "Готово" : "Не готово" )) ;
            }
            Console.WriteLine("\n \n");
            Console.WriteLine("Напишите номер задачи для ее открытия");

        }

        public void GetPageCreate()
        {
            Console.WriteLine("Создать todo");
            Console.WriteLine("Введите задачу: ");
        }

        public int GetPageTodo(TodoItem todo)
        {
            Console.WriteLine("Todo № " + todo.Id);         
            if (todo != null)
            {
                Console.WriteLine("Задача | " + todo.Title);
                Console.WriteLine("Состояние | " + (todo.IsDone ? "Готово" : "Не готово \n \n"));
                Console.WriteLine("1.Завершить задачу");
                Console.WriteLine("2.Изменить задачу");

                return todo.Id;
            }
            else
            {
                Console.WriteLine("Такой задачи нет. Нажмите на любую клавишу, чтобы вернутся в меню...");

                return 0;
            }
        }

    }
}
