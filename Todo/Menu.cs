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

        public void GetPageCreate()
        {
            Console.WriteLine("Создать todo");
            Console.WriteLine("Введите задачу: ");
        }

        public void GetAllTodos(List<TodoItem> todoItems)
        {
            if (todoItems.Count > 0)
            {
                Console.Clear();
                Console.WriteLine("Список всех задач:");
                foreach (var item in todoItems)
                {
                    Console.WriteLine(item.Id + "." + item.Title + " | " + "Состояние: " + (item.IsDone ? "Готово" : "Не готово"));
                }
                Console.WriteLine("\n \n");
                Console.WriteLine("Напишите номер задачи для ее открытия");
            }
            else
            {
                Console.WriteLine("Задачи еще не созданы");
            }


        }

        public void GetPageTodo(TodoItem todo)
        {
            Console.WriteLine("Todo № " + todo.Id);
            Console.WriteLine("Задача | " + todo.Title);
            Console.WriteLine("Состояние | " + (todo.IsDone ? "Готово" : "Не готово \n \n"));
            Console.WriteLine("1.Завершить задачу");
            Console.WriteLine("2.Изменить задачу");
        }

        public void GetNullTodo()
        {
            Console.Clear();
            Console.WriteLine("Задачи с таким номером нет");
        }


    }
}
