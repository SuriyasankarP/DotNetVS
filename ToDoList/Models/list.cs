using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
#pragma warning disable IDE1006 // Naming Styles
    public class list
#pragma warning restore IDE1006 // Naming Styles
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Item { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
