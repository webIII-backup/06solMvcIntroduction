using BlackJackGame.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SnakeEyesGame.Models.Extensions;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BlackJackGame.Controllers
{
    public class HomeController : Controller
    {
        private BlackJack _blackJack;
        private readonly string _sessionKey = "BlackJack";

        public IActionResult Index()
        {
            _blackJack = new BlackJack();
            HttpContext.Session.SetObject(_sessionKey, _blackJack);
            return View(_blackJack);
        }

        public IActionResult NextCard() {
            _blackJack = HttpContext.Session.GetObject<BlackJack>(_sessionKey); 
            _blackJack.GivePlayerAnotherCard();
            HttpContext.Session.SetObject(_sessionKey, _blackJack);
            return View(nameof(Index), _blackJack);
        }
        public IActionResult Pass() {
            _blackJack = HttpContext.Session.GetObject<BlackJack>(_sessionKey);
            _blackJack.PassToDealer();
            HttpContext.Session.SetObject(_sessionKey, _blackJack);
            return View(nameof(Index), _blackJack);
        }
        

    }
}
