using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValeriaGutierrez.Data;
using ValeriaGutierrez.Models;

namespace ValeriaGutierrez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarajaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BarajaController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<Naipe>> GetCancion()
        {
            var list = await _context.Naipe.ToListAsync();
            var max = list.Count;
            int index = new Random().Next(0, max);
            var cancion = list[index];

            if (cancion == null)
            {
                return NoContent();
            }
            return cancion;
        }
    }
}
