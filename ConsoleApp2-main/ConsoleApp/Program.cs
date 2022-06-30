using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager managerr = new Manager();
            string option;
            do
            {
                Console.WriteLine("1.Tapsiriq yarat");//
                Console.WriteLine("2.Butun tapsiriqlara bax");//
                Console.WriteLine("3.Vaxti kecmis tapsiriqlara bax");//
                Console.WriteLine("4.Secilmis statuslu tapsiriqlara bax");
                Console.WriteLine("5.Tarix intervalina gore axtar");
                Console.WriteLine("6.Tapsirigin statusunu deyismek");
                Console.WriteLine("7.Tapsirigi editlemek");//
                Console.WriteLine("8.Tapsirigi silmek");//
                Console.WriteLine("9.Tapsiriqlarda axtaris");//
                Console.WriteLine("0.Cixis");

                do
                {
                    Console.Write("Seciminizi daxil edin:");
                    option=Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(option)||(option!="1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "6" && option != "7" && option != "8" && option != "9" && option != "0") );
                switch (option)
                {
                    case "1":
                        TodoItem item1 = CreateTask();
                        managerr.AddTodoItem(item1);
                        break;
                    case "2":
                        List<TodoItem> itemss = managerr.GetAllTodoItems();
                        foreach (var item in itemss)
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "3":
                        foreach (var item in managerr.GetAllDelayedTasks())
                        {
                            Console.WriteLine(  item);
                        }
                        
                        break;
                    case "4":
                        Console.WriteLine("Statusunuzu secin:");
                        string[] enumm = Enum.GetNames(typeof(Status));
                        string answer = Console.ReadLine();
                        foreach (var item in Enum.GetNames(typeof(Status)))
                        {
                            Console.WriteLine(item);
                        }

                        break;

                    case "5":
                        break;
                    case "6":

                        break;
                    case "7":
                        Console.WriteLine("Editlemek istediyiniz hisseni daxil edin:");
                        string neededToEdit = Console.ReadLine();
                        managerr.EditTodoItem();
                        break;
                    case "8":
                        Console.WriteLine("Silmek istediyiniz tapsirigin nomresini daxil edin :");
                        string noStr = Console.ReadLine();
                        int no = Convert.ToInt32(noStr);

                        managerr.DeleteTodoItem(no);

                        break;
                    case "9":
                        Console.WriteLine("Axtarmaq istediyiniz basligi daxil edin:");
                        managerr.SearchTodoItems();
                        break; 
                    
:                    default:
                        break;
                }
            } while (option !="0"); 
        }
        
        static TodoItem CreateTask()
        {
            string title;
            do
            {
                Console.WriteLine("Tapsirigin basligini daxil edin:");
                 title = Console.ReadLine();
            } while (title==null);
            string description;
            do
            {
                Console.WriteLine("Tapsirigin detalli izahini daxil edin:");
                 description = Console.ReadLine();
            } while (description==null);

            string deadlineStr;
            DateTime deadline;
            do
            {
                Console.WriteLine("Tapsirigin bitme tarixini daxil edin:");
               deadlineStr = Console.ReadLine();
            } while (DateTime.TryParse(deadlineStr,out deadline));
            
           
            TodoItem newItem = new TodoItem()
            {
              
                Title = title,
                Description = description,
                Deadline = deadline
            };

            return newItem;
        }



            
        
    }
}
