using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookManager.Models;
using StraussDA.BookLibrary;

namespace BookManager.Controllers
{
    public class HomeController : Controller
    {
        private BookRepository _bookRepo = new BookRepository();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var myFantasy = new Fantasy
            {
                Year = 2012,
                Title = "Dragon's Breath",
                Author = "Sam Goldsman",
                NumberOfBooksInSeries = 3
            };

            _bookRepo.Add(myFantasy);

            return View(myFantasy);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
