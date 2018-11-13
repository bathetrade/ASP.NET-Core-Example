using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using MvcMovie.Services;
using MvcMovie.ViewModels;

namespace MvcMovie.Controllers
{
    public class ServiceTestController : Controller
    {
        public IActionResult Index(MathService math, int x, int y, string operation="Add")
        {
            var model = new ServiceTestViewModel()
            {
                MathService = math,
                x = x,
                y = y,
                Operation = (Operation)Enum.Parse(typeof(Operation), operation)
            };
            return View(model);
        }
    }
}
