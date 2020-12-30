using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Asp.Net_5_TestDemo.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Asp.Net_5_TestDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(ILogger<HomeController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy() => View();
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Gallery()
        {
           
            var imgPath = Path.Combine(hostingEnvironment.ContentRootPath, "wwwroot/img");
            DirectoryInfo directoryInfo = new DirectoryInfo(imgPath);
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            FileManagerModel.fileInfos = fileInfo;

            return View(FileManagerModel.fileInfos);
        }
    }
}
