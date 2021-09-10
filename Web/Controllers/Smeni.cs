using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class Smeni : Controller
    {
        public IActionResult Index()
        {
            Rezervaciq model = new Rezervaciq();
            model.Smeni = new List<Smqna>();
            model.Smeni.Add(new Smqna()
            {

                Id = 0,
                Nomer = "",
            });

            model.Smeni.Add(new Smqna()
            {

                Id = 1,
                Nomer = "I",

            });
            model.Smeni.Add(new Smqna()
            {
                Id = 2,
                Nomer = "II",
            });
            model.Smeni.Add(new Smqna()
            {
                Id = 3,
                Nomer = "III",
            });
            model.Smeni.Add(new Smqna()
            {

                Id = 4,
                Nomer = "IV",
            });
            model.Smeni.Add(new Smqna()
            {

                Id = 5,
                Nomer = "V",
            });
            model.Smeni.Add(new Smqna()
            {

                Id = 6,
                Nomer = "VI",
            });
            model.Smeni.Add(new Smqna()
            {
                Id = 7,
                Nomer = "VII",
            });
            model.Smeni.Add(new Smqna()
            {
                Id = 8,
                Nomer = "VIII",
            });

           
            model.Bungalo.Add(new Bungala()
                {
               Id=1,
            });
            model.Bungalo.Add(new Bungala()
            {
                Id = 2,
            });

            return View(model);
        }
        
    }
}