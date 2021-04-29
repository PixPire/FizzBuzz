using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplikacjaFizzBuzz.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace AplikacjaFizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzz Fizzbuzz { get; set; }
        
        [BindProperty]
        public string Wynik { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Fizzbuzz.wynik = Fizzbuzz.Fizzbuzz(Fizzbuzz.liczba);
                HttpContext.Session.SetString("SessionOstatnio_Szukane", JsonConvert.SerializeObject(Fizzbuzz));
            }
                return RedirectToPage("Index", new { Wynik = Fizzbuzz.wynik });
            
        }

    }
}
