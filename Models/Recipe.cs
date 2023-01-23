using System.ComponentModel.DataAnnotations;

namespace CrudInMvc;

public class Recipe
{
    public Guid ID { get; set; }
    
    [Required(ErrorMessage = "Please enter a name for the recipe.")]
    [StringLength(255, ErrorMessage = "The recipe name must be less than 255 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter the ingredients for the recipe.")]
    public string Ingredients { get; set; }

    [Required(ErrorMessage = "Please enter the instructions for the recipe.")]
    public string Instructions { get; set; }
}