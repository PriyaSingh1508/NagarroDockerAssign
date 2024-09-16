using System.ComponentModel.DataAnnotations;

namespace ToDoApplication.Models
{
    public class Item
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Title { get; set; }
    }
}
