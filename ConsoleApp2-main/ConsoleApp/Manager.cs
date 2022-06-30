using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp.Exceptions;

namespace ConsoleApp
{
    class Manager : ITodoManager
    {
        public List<TodoItem> sheets { get; set ; }

        public void AddTodoItem(TodoItem item)
        {
            if (item!=null)
            {
                sheets.Add(item);
            }
            
        }

        public void ChangeTodoItemStatus(int no, Status status)
        {
            TodoItem statusBeingChanged = sheets.Find(x => x.No.== no);
            
           

        }

        public void DeleteTodoItem(int no)
        {
             TodoItem item=sheets.Find(x => x.No == no);
            sheets.Remove(item);

        }

        public void EditTodoItem(int no, string desc = null, string title = null, DateTime? deadline = null)
        {
           TodoItem findNo = sheets.Find(x => x.No == no);
            if (findNo!=null)
            {
                if (findNo.Description!=null)
                {
                    findNo.Description = desc;
                }
                if (findNo.Title!=null)
                {
                    findNo.Title = title;
                }
                if (findNo.Deadline!=null)
                {
                    findNo.Deadline = (DateTime)deadline;
                }
            }
            else
            {
                Console.WriteLine("Bu nomreli task yoxdur!!");
            }

           
           
               
        }

       

        public List<TodoItem> FilterTodoItem(Status status, DateTime fromDate, DateTime toDate)
        {
            if (toDate>fromDate)
            {
                List<TodoItem> checkTime = sheets.FindAll(x => x.Deadline > fromDate && x.Deadline < toDate);
                if (checkTime!= null)
                {
                    List<TodoItem> checkStatus = sheets.FindAll(x => x.status == status);
                   return checkStatus;
                }
                else
                {
                    return checkTime;
                }
            }
            else
            {

                throw new NotinLogicalTimeLine();
            }
        }

        public List<TodoItem> GetAllDelayedTasks()
        {
            List<TodoItem> delayedTasks = sheets.FindAll(x => x.Deadline < DateTime.Now && x.status==Status.Todo);
            return delayedTasks;
        }

        public List<TodoItem> GetAllTodoItems()
        {
            return sheets;
        }

        public List<TodoItem> GetAllTodoItemsByStatus(Status status)
        {
            List<TodoItem> getItems = sheets.FindAll(x => x.status == status);
            return getItems;

        }

        public List<TodoItem> SearchTodoItems(string text)
        {
            
            List<TodoItem >findTitle = sheets.FindAll(x => x.Title.Contains(text));
            return findTitle;
        }

        internal void SearchTodoItems()
        {
            throw new NotImplementedException();
        }
    }
}
