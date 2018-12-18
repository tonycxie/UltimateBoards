using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using UltimateBoards.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TwitchLib.Api;

namespace UltimateBoards.Controllers
{
    public class AppController : Controller
    {
        private UltimateBoardsContext dbContext;

        public AppController(UltimateBoardsContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        [Route("streams")]
        public IActionResult Streams()
        {
            return View();
        }
    }
}
