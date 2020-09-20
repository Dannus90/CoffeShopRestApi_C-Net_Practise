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

namespace ExpressoAPI.Controllers
{
    [Route("api/[controller]")]
    public class MenusController : ControllerBase
    {
        private ExpressoDbContext _expressoDbContext;

        public MenusController(ExpressoDbContext expressoDbContext)
        { 
            _expressoDbContext = expressoDbContext;
        }
        // Get: api/menus
        [HttpGet]
        public IActionResult GetMenus()
        {
            var menus = _expressoDbContext.Menus.Include("SubMenus");
            if(menus == null)
            {
                return NotFound("No Records Found");
            }
            return Ok(menus);
        }

        // Get api/menus/{id}
        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = _expressoDbContext.Menus.Include("SubMenus").FirstOrDefault(m=>m.Id == id);
            if(menu == null)
            {
                return NotFound("No Record Found...");
            }
            return Ok(menu);
        }
    }
}