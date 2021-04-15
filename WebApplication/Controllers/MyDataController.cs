using ConsoleApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class MyDataController : Controller
    {
        

        public IActionResult MyData()
        {
            var service = new ConsoleApp.Services.ImportJsonService();
            var filePath = ConsoleApp.Utils.FilePath.GetFullPath("高雄活動.txt");
            List<Activity> datas = service.LoadFormFile(filePath);
            return View(datas);
        }

        
    }
}
