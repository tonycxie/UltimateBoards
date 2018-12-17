using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using UltimateBoards.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace UltimateBoards.Controllers
{
    public class AppController : Controller
    {
        private UltimateBoardsContext dbContext;

        public AppController(UltimateBoardsContext context)
        {
            dbContext = context;
        }

        // GET: /Home/
        [HttpGet]
        [Route("streams")]
        public IActionResult Streams()
        {
            return View();
        }
    }
}
