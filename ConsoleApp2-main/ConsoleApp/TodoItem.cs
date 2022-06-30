using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class TodoItem
    {
        public TodoItem()
        {
            _count++;
            No = _count;
        }
        public  int No;
        public string Title;
        public string Description;
        public DateTime Deadline;
        public int Count => _count;
        private static int _count;
        public DateTime TypeChangeAt;
        public Status status;
        public void ShowInfo()
        {
            Console.WriteLine($"No:{No}-Title:{Title}-Description:{Description}-Deadline:{Deadline}-Status:{status} ");
        }

    }
}
