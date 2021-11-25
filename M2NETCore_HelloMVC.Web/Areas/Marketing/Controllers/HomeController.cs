using M2NETCore_HelloMVC.Web.Areas.Marketing.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace M2NETCore_HelloMVC.Web.Areas.Marketing.Controllers
{
    [Area("Marketing")]
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }



        private List<Product> GetProducts()
        {
            var pathFileJson = "Areas\\Marketing\\Data\\products.json";
            var folder = Path.Combine(Directory.GetCurrentDirectory(), pathFileJson);

            var json = System.IO.File.ReadAllText(folder);
            var products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }
        


    }
}
