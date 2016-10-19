using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numberOfTimes = 1)
        {
            numberOfTimes++;
            return HtmlEncoder.Default.Encode($"Hello {name}, numTimes: {numberOfTimes}");
        }
    }
}
