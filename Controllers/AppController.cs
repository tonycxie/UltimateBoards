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
        // private TwitchAPI api;

        public AppController(UltimateBoardsContext context)
        {
            dbContext = context;
            // api = new TwitchAPI();
            // api.Settings.ClientId = "i0gcva3x1ue9yfivg7rrwkv6s6i4c7";
            // api.Settings.AccessToken = "6hslmdv9s247n5dot1qjlc44pyheht";
        }

        // private async Task AsyncCalls()
        // {
        //     bool isStreaming = await api.V5.Streams.BroadcasterOnlineAsync("zero");
        //     var games = await api.V5.Search.SearchGamesAsync("Super Smash Bros Ultimate");
        // }

        // GET: /Home/
        [HttpGet]
        [Route("streams")]
        public IActionResult Streams()
        {
            return View();
        }
    }
}
