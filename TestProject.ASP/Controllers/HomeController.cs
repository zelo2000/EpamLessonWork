using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.ASP.Models;
using TestProject.Common.Core;
using TestProject.Common.Core.Displayers;
using TestProject.TaskLibrary;

namespace TestProject.ASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var lessonList = new SortedDictionary<string, List<string>>();
            foreach (var lesson in TaskStorage.Tasks)
            {
                lessonList.Add(lesson.Key, new List<string>());
                foreach (var task in TaskStorage.Tasks[lesson.Key])
                {
                    lessonList[lesson.Key].Add(task.Key);
                }
            }

            return View(lessonList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
