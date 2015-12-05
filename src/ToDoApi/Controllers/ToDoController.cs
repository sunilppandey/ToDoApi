using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ToDoApi.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        // The [FromServices] attribute tells MVC to inject the ITodoRepository that we registered in the Startup class.
        [FromServices]
        public IToDoRepository ToDoItems { get; set; }

        [HttpGet]
        public IEnumerable<ToDoItem> GetAll()
        {
            return ToDoItems.GetAll();
        }

        [HttpGet("{id}", Name ="GetToDo")]
        public IActionResult GetById(string id)
        {
            var item = ToDoItems.Find(id);
            if(item == null)
            {
                return HttpNotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ToDoItem item)
        {
            if(item == null)
            {
                return HttpBadRequest();
            }
            ToDoItems.Add(item);
            return CreatedAtRoute("GetToDo", new { controller = "ToDo", id = item.Key }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] ToDoItem item)
        {
            if (item == null || item.Key != id)
            {
                return HttpBadRequest();
            }

            var todo = ToDoItems.Find(id);
            if (todo == null)
            {
                return HttpNotFound();
            }

            ToDoItems.Update(item);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            ToDoItems.Remove(id);
        }
    }
}
