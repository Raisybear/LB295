using LB295.Interfaces;
using Microsoft.AspNetCore.Mvc;
using LB295.Models;
using LB295.Data;

namespace LB295.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuchController : Controller
    {
        private readonly IBuchRepository _buchRepository;
        private readonly DataContext context;

        public BuchController(IBuchRepository buchRepository, DataContext context)
        {
            _buchRepository = buchRepository;
            this.context = context;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Buch>))]
        public IActionResult GetBücher() 
        { 
            var bücher = _buchRepository.GetBücher();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(bücher);
        }
    }
}