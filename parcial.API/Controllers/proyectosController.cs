using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using parcial.API.Data;
using parcial.shared.Entities;

namespace parcial.API.Controllers
{
    [ApiController]
    [Route("api/proyectos")]    
    public class proyectosController : ControllerBase { 

     private readonly DataContext _context;

     public proyectosController(DataContext context) 
        {
        
        _context = context;
        }
       
        //get por parametro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)

        {

            await _context.proyectos.FirstOrDefaultAsync(x => x.Id == id);

            return Ok();

        }
        //get por lista
        [HttpGet]
        public async Task<ActionResult> Get()

        {

            return Ok(await _context.proyectos.ToListAsync());

        }
        // insertar un registro
        [HttpPost]

        public async Task<ActionResult> post(proyecto proyecto)

        {

            _context.Add(proyecto);
            await _context.SaveChangesAsync();
            return Ok(proyecto);
        }


    }
}

 
