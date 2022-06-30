using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    interface ITodoManager
    {
        List<TodoItem> sheets { get; set; }
        public void AddTodoItem(TodoItem item);
        public  List<TodoItem> GetAllTodoItems();
        public List<TodoItem> GetAllDelayedTasks();
        public void ChangeTodoItemStatus(int no,Status status);
        public void EditTodoItem(int no, string desc, string title, DateTime? deadline);
        public void DeleteTodoItem(int no);
        public List<TodoItem> GetAllTodoItemsByStatus(Status status);
        public List<TodoItem> SearchTodoItems(string text);
        public List< TodoItem> FilterTodoItem(Status status, DateTime fromDate, DateTime toDate);



    }
}
