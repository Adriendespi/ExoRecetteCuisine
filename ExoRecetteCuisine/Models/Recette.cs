using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExoRecetteCuisine.Models
{
    public class Recette
    {
        public Guid guid { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> Ingredient { get; set; }
    }

    public class Recetteform
    {
        [DisplayName ("Name")]
        [Required(ErrorMessage = "Le Nom est obligatoire !")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "La Description est obligatoire !")]
        public string Description { get; set; }


       
        [Required(ErrorMessage = "Remplissez le nombre d'ingredients demander")]
        public List<string> Ingredient { get; set; }

    }

    public class IngAdd
    {
        
        public List<string> Ingredient { get; set; }
    }
}
