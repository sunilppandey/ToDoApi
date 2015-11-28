﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Models
{
    /// <summary>
    /// This interface defines basic CRUD operations
    /// </summary>
    public interface IToDoRepository
    {
        void Add(ToDoItem item);
        IEnumerable<ToDoItem> GetAll();
        ToDoItem Find(string key);
        ToDoItem Remove(string key);
        void Update(ToDoItem item);
    }
}
