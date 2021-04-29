using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplikacjaFizzBuzz.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace AplikacjaFizzBuzz.Pages
{
    public class Ostatnio_SzukaneModel : PageModel
    {
        public FizzBuzz fizzbuzz;

        public void OnGet()
        {
            var SessionOstatnio_Szukane = HttpContext.Session.GetString("SessionOstatnio_Szukane");
            if (SessionOstatnio_Szukane != null) fizzbuzz = JsonConvert.DeserializeObject<FizzBuzz>(SessionOstatnio_Szukane);
        }
    }
}
