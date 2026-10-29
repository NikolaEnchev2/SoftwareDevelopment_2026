using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nikola.todomanager
{
    internal class TodoService
    {
        private readonly List<TodoItem> tasks = new List<TodoItem>();
        private int nextID = 1;

        public List<TodoItem> GetAll()
        {
            return tasks;
        }

        public TodoItem FindById(int id)
        {
            foreach (TodoItem item in tasks)
            {
                if(item.Id == id) return item;
            }
            return null;
        }

        public void Add(string title, string description, DateTime deadLine)
        {
            TodoItem task = new TodoItem(nextID, title, description, deadLine);
            tasks.Add(task);
            nextID++;
        }

        public void Completed(int id)
        {
            TodoItem item = FindById(id);

            if (item == null)
            {
                throw new ArgumentException("Няма задача с такова ID.");
            }

            item.Completed();
            
        }
    }
}
