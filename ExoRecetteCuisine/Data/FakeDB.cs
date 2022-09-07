using ExoRecetteCuisine.Models;

namespace ExoRecetteCuisine.Data
{
    public static class FakeDB
    {
        public static ICollection<Recette> recettes = new List<Recette>()
        {
            new Recette
            {
                guid = Guid.NewGuid(),
                Name = "Tiramitsu",
                Description = "Desert a la creme de mascarpone et a l'amareto",
                Ingredient = new List<string>
                {
                    "mascarpone","amareto","Cacao","Oeufs","Speculos","Sucre"
                }

            },

             new Recette
            {
                guid = Guid.NewGuid(),
                Name = "Buche au chocola",
                Description = "Desert de Noel au Chocolat",
                Ingredient = new List<string>
                {
                    "Chocolat","Creme","Oeufs","Farine","Lait"
                }

            }

        };
        
    }
}
