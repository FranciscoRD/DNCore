using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Services;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreTodo.Controllers
{
    [Authorize]
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;
        private readonly UserManager<IdentityUser> _userManager;

        public TodoController(ITodoItemService todoItemService, 
            UserManager<IdentityUser> userManager)
        {
            _todoItemService = todoItemService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var currenUser = await _userManager.GetUserAsync(User);
            if(currenUser == null) return Challenge();

            var items = await _todoItemService.GetIncompleteItemsAsync(currenUser);

            var model = new TodoViewModel()
            {
                Items = items
            };
            return View(model);
        }
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddItem(TodoItem newItem)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var currentUser = await _userManager.GetUserAsync(User);
            if(currentUser == null) return Challenge();

            var succesful = await _todoItemService.AddItemAsync(newItem,currentUser);

            if (!succesful)
            {
                return BadRequest("No se puede agregar elemento.");
            }

            return RedirectToAction("Index");
        }
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MarkDone(Guid id)
        {
            if (id == Guid.Empty)
            {
                return RedirectToAction("Index");
            }

            var currentUser = await _userManager.GetUserAsync(User);
            if(currentUser == null) return Challenge();

            var succesful = await _todoItemService.MarkDoneAsync(id, currentUser);
            
            if (!succesful)
            {
                return BadRequest("No se puede marcar como hecho");
            }

            return RedirectToAction("Index");
        }
    }
}