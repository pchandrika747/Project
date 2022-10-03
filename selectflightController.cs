using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Linq;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class selectflightController : ControllerBase
    {
        public selectflightController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }

        [HttpGet]

        public ActionResult Get()
        {
            var data = _context.selectflight.ToList();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public ActionResult Get(int? id)
        {
            var data = _context.selectflight.FirstOrDefault(f => f.id == id);
            return Ok(data);
        }
        [HttpPost]
        public ActionResult Post(selectflight flight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.selectflight.Add(flight);
                _context.SaveChanges();
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public ActionResult Update(int? id, selectflight flight)
        {
            var data = _context.selectflight.FirstOrDefault(f => f.id == id);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                data.flightname = flight.flightname;
                _context.SaveChanges();
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int? id)
        {
            var data = _context.selectflight.FirstOrDefault(f => f.id == id);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.selectflight.Remove(data);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
