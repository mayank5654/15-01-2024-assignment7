using assignment7.Models;
using Microsoft.AspNetCore.Mvc;

namespace assignment7.Controllers
{
    public class PlayersController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player {Pid=1,PName="ms dhoni",PCountry="india",Ptype="wicket keeper"},
            new Player {Pid=2,PName="bumrah",PCountry="india",Ptype="bowler"},
            new Player {Pid=3,PName="rohit sharma",PCountry="india",Ptype="batsman"}
        };

        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        [HttpPost]
        public IActionResult Create
            (Player pro)
        {
            if (ModelState.IsValid)
            {
                players.Add(pro);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
