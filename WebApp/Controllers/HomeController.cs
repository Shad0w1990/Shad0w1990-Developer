using AppService.Commads;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private CommadQueryDispatcher _dispatcher;

        public HomeController(CommadQueryDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        public  IActionResult Index()
        {
            CreatePersonCommand personCommand=new CreatePersonCommand("ehsan","khorsand",28);

            _dispatcher.Handler(personCommand);
            return View();
        }
    }
}