using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Models
{
    public class ToDoRepository : IToDoRepository
    {
        static ConcurrentDictionary<string, ToDoItem> _todos = new ConcurrentDictionary<string, ToDoItem>();

        public ToDoRepository()
        {
            Add(new ToDoItem { Name = "item1" });
        }

        public void Add(ToDoItem item)
        {
            item.Key = Guid.NewGuid().ToString();
            _todos[item.Key] = item;
        }

        public ToDoItem Find(string key)
        {
            ToDoItem item;
            _todos.TryGetValue(key, out item);
            return item;
        }

        public IEnumerable<ToDoItem> GetAll()
        {
            return _todos.Values;
        }

        public ToDoItem Remove(string key)
        {
            ToDoItem item;
            _todos.TryGetValue(key, out item);
            _todos.TryRemove(key, out item);
            return item;
        }

        public void Update(ToDoItem item)
        {
            _todos[item.Key] = item;
        }
    }
}
