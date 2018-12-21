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

        [HttpGet]
        [Route("home")]
        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        [Route("forum")]
        public IActionResult Forum()
        {
            return View();
        }

        [HttpGet]
        [Route("forum/{id}")]
        public IActionResult Threads(int id) 
        {
            return View();
        }

        [Route("guides")]
        public IActionResult Guides()
        {
            return View();
        }

        [HttpGet]
        [Route("events")]
        public IActionResult Events()
        {
            return View();
        }

        [HttpGet]
        [Route("/forum/{cat_id}/{thread_id}")]
        public IActionResult Thread(int cat_id, int thread_id)
        {
            return View();
        }
    }
}
