using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskListCapstoneEFCore.Models;
using Tasks = TaskListCapstoneEFCore.Models.Tasks;

namespace TaskListCapstoneEFCore.Controllers
{
    [Authorize]
    public class TasksController : Controller
    {
        private readonly TasksDbContext _context;

        public TasksController(TasksDbContext context)
        {
            _context = context;
        }
        public IActionResult TasksIndex()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var thisUsersTasks = _context.Task.Where(x => x.AspNetUsersId == id).ToList();
            return View(thisUsersTasks);
        }

        public IActionResult MarkComplete(int id)
        {
            Tasks found = _context.Task.Find(id);

            if (found != null)
            {
                //change the things (we're changing the completed status)
                found.Completed = !found.Completed;

                //modify the state of this entry in the database
                _context.Entry(found).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(found);
                _context.SaveChanges();
            }
            return RedirectToAction("TasksIndex", new { id = found.Id });
        }

        public IActionResult DeleteTask(int id)
        {
            Tasks found = _context.Task.Find(id);
            if (found != null)
            {
                _context.Task.Remove(found);
                _context.SaveChanges();
            }
            return RedirectToAction("TasksIndex", new { id = found.Id });
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(Tasks newTask)
        {
            newTask.AspNetUsersId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (ModelState.IsValid)
            {
                _context.Task.Add(newTask);
                _context.SaveChanges();
                return RedirectToAction("TasksIndex");
            }
            else
            {
                return View();
            }
        }
    }
}