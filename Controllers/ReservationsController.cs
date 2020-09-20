using System.IO;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using ExpressoAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExpressoAPI.Models;
using Microsoft.AspNetCore.Http;

namespace ExpressoAPI.Controllers
{
    [Route("api/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private ExpressoDbContext _expressoDbContext;

        public ReservationsController(ExpressoDbContext expressoDbContext)
        { 
            _expressoDbContext = expressoDbContext;
        }
        // Get: api/menus
        [HttpPost]
        public IActionResult Post([FromBody]Reservation reservation)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _expressoDbContext.Reservations.Add(reservation);
            _expressoDbContext.SaveChanges();

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}