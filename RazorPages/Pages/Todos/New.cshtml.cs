using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data;

namespace RazorPages.Pages.Todos
{
    public class NewModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public NewModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public ToDoItem NewTodo { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.ToDoItems.Add(NewTodo);
                _db.SaveChanges();
                return RedirectToPage("/Todos/Index");
            }
            return Page();
        }
    }
}
