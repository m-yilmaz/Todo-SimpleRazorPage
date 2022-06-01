using System.ComponentModel.DataAnnotations;

namespace RazorPages.Data
{
    public class ToDoItem
    {
        public int Id { get; set; }
        [Required, MaxLength(250)]
        public string Title { get; set; }

        public bool IsDone { get; set; }

    }
}
