using Microsoft.AspNetCore.Mvc;
using TestProject.Common.Core;
using TestProject.TaskLibrary;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProject.ASP.Controllers
{
    public class TaskController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string lesson, string task)
        {
            Logger.SetLogger(new ASPLogger());
            ASPLogger.ViewData = ViewData;

            ViewData["Title"] = lesson + " - " + task;
            TaskStorage.Tasks[lesson][task].Run();
            return View();
        }          
    }
}
