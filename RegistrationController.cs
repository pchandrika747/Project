using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {

        public RegistrationController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }

        [HttpGet]

        public ActionResult Get()
        {
            var data = _context.Registration.ToList();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public ActionResult Get(int? id)
        {
            var data = _context.Registration.FirstOrDefault(r => r.id == id);
            return Ok(data);
        }
        [HttpPost]
        public ActionResult Post(Registration cat)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Registration.Add(cat);
                _context.SaveChanges();
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public ActionResult Update(int? id, Registration cat)
        {
            var data = _context.Registration.FirstOrDefault(r => r.id == id);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                data.firstname = cat.firstname;
                _context.SaveChanges();
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int? id)
        {
            var data = _context.Registration.FirstOrDefault(r => r.id == id);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Registration.Remove(data);
                _context.SaveChanges();
                return Ok();
            }
        }
        
    }
}
