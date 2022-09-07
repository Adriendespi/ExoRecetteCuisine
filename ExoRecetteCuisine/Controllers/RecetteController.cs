using ExoRecetteCuisine.Data;
using ExoRecetteCuisine.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExoRecetteCuisine.Controllers
{

    public class RecetteController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Recette> recettes = FakeDB.recettes;
            return View(recettes);
        }

        public IActionResult Recap()
        {
            IEnumerable<Recette> recettes = FakeDB.recettes;
            return View(recettes);
        }
        public IActionResult Detail(Guid guid)
        {
            return View(FakeDB.recettes.SingleOrDefault(p => p.guid == guid));
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Recetteform recetteform)
        {
            if (ModelState.IsValid)
            {
                FakeDB.recettes.Add(new Recette { guid = Guid.NewGuid(), Name = recetteform.Name, Description = recetteform.Description, Ingredient = recetteform.Ingredient });
                return RedirectToAction(nameof(Recap));
            }
            else
            {
                return View();
            }
        }
        public IActionResult Supp(Guid guid)
        {
            FakeDB.recettes.Remove(FakeDB.recettes.SingleOrDefault(p => p.guid == guid));
            return RedirectToAction(nameof(Recap));

        }
        public IActionResult Modif(Guid guid)
        {
            return View(FakeDB.recettes.SingleOrDefault(p => p.guid == guid));
        }

        [HttpPost]
        public IActionResult Modif(Recetteform recetteform , Guid guid)
        {
          Recette recette =FakeDB.recettes.SingleOrDefault(p => p.guid == guid);
            recette.Ingredient = recetteform.Ingredient;
            recette.Description = recetteform.Description;
            recette.Name = recetteform.Name;
            

            return RedirectToAction(nameof(Recap));
        }
    }
}
