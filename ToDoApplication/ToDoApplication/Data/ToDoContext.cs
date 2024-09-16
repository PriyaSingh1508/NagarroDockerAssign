using Microsoft.EntityFrameworkCore;
using System;
using ToDoApplication.Models;

namespace ToDoApplication.Data
{
    public class ToDoContext:DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
