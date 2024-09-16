using Microsoft.AspNetCore.Mvc;
using ToDoApplication.Data;
using ToDoApplication.Models;

namespace ToDoApplication.Controllers
{
    [Route("item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ToDoContext _context;

        public ItemController(ToDoContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_context.Items.ToList());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Item item)
        {
            if(ModelState.IsValid)
            {
                await _context.Items.AddAsync(item);
                await _context.SaveChangesAsync();
                return Ok();
            }
            return BadRequest();
        }

    }
}
