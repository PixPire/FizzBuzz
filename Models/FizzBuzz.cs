using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AplikacjaFizzBuzz.Models
{
    public class FizzBuzz
    {
        [Range(1, 1000, ErrorMessage ="Poza zakresem"), Required]
        public int liczba { get; set; }
        public string wynik { get; set; }
        public string Fizzbuzz(int liczba)
        {
            if (liczba % 15 == 0) return "fizzbuzz";
            if (liczba % 5 == 0) return "Buzz";
            if (liczba % 3 == 0) return "Fizz";
            string wyjscie;
            wyjscie = "Liczba " + liczba + "nie spełnia kryteriów";
            return wyjscie;
        }

    }
}
