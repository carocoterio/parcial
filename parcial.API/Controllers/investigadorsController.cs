using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using parcial.API.Data;
using parcial.shared.Entities;

namespace parcial.API.Controllers
{
    [ApiController]
    [Route("api/investigadors")]
    public class investigadorsController : ControllerBase
    {

        private readonly DataContext _context;

        public investigadorsController(DataContext context)
        {

            _context = context;
        }

        //get por parametro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)

        {

            await _context.Investigadors.FirstOrDefaultAsync(x => x.Id == id);

            return Ok();

        }
        //get por lista
        [HttpGet]
        public async Task<ActionResult> Get()

        {

            return Ok(await _context.Investigadors.ToListAsync());

        }
        // insertar un registro
        [HttpPost]

        public async Task<ActionResult> post(investigador investigador)

        {

            _context.Add(investigador);
            await _context.SaveChangesAsync();
            return Ok(investigador);
        }


    }
}

