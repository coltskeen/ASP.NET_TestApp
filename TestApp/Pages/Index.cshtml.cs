using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TestApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        readonly string name = "The Wizard";
        readonly string username = "TheWhiteWizard";
        readonly int age = 580;
        readonly string favPower = "Confundo";
        List<string> powers = new List<string>()
        {
          "Expelliarmus",
          "Lumos",
          "Sectumsempra",
          "Wingardium Leviosa",
          "Petrificus Totalus",
          "Crucio",
          "Alohomora",
          "Accio",
          "Riddikulus",
          "Reparo",
          "Avada Kedavra",
          "Obliviate",
          "Confundo",
          "Expecto Patronum"
        };

        public string Greet { get; set; }
        //public string FavoritePower { get; set; }
        //public string Name { get; set; }
        //public int Age { get; set; }
        public List<string> Powers { get; set; }

        public void OnGet()
        {
            Greet = "Fairest and fallen, greetings!";
            @ViewData["myName"] = name;
            ViewData["username"] = username;
            @ViewData["myAge"] = age;
            @ViewData["FavoritePower"] = favPower;
            Powers = powers;
        }
    }
}

