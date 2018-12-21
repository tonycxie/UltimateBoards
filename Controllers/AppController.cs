using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using UltimateBoards.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

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

        [HttpGet]
        [Route("forum/{CatId}/new_thread")]
        public IActionResult NewThread()
        {
            return View();
        }

        [HttpPost]
        [Route("forum/{CatId}/add_thread")]
        public IActionResult AddThread(int CatId, Thread thread)
        {
            if (ModelState.IsValid)
            {
                int? UserId = HttpContext.Session.GetInt32("UserId");
                Thread newThread = new Thread
                {
                    Content = thread.Content,
                    UserId = (int)UserId,
                    CategoryId = CatId
                };
                dbContext.Add(newThread);
                dbContext.SaveChanges();
                return RedirectToAction("Threads", new {id = CatId});
            }
            return View("NewThread");
        }

        [HttpGet]
        [Route("forum/{CatId}/{ThreadId}")]
        public IActionResult ShowThread(int CatId, int ThreadId)
        {
            return View();
        }

        [HttpPost]
        [Route("forum/{CatId}/{ThreadId}/new_comment")]
        public IActionResult NewComment(int CatId, int ThreadId, ThreadComment comment)
        {
            if (ModelState.IsValid)
            {
                int? UserId = HttpContext.Session.GetInt32("UserId");
                ThreadComment newComment = new ThreadComment
                {
                    Comment = comment.Comment,
                    UserId = (int)UserId,
                    ThreadId = ThreadId
                };
                dbContext.Add(newComment);
                dbContext.SaveChanges();
                return RedirectToAction("ShowThread", new {CatId = CatId, ThreadId = ThreadId});
            }
            return View("ShowThread");
        }

        [HttpGet]
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
