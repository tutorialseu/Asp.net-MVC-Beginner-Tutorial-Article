using Microsoft.AspNetCore.Mvc;

namespace CrudInMvc.Models;

public class RecipeController : Controller
{
    private readonly Recipes recipes;

    public RecipeController(Recipes recipes)
    {
        this.recipes = recipes;
    }

    public ActionResult List()
    {
        var recipesList = recipes.List();
        return View(recipesList);
    }

    public ActionResult Details(Guid id)
    {
        var recipe = recipes.FindById(id);
        return View(recipe);
    }

    public ActionResult Add()
    {
        throw new NotImplementedException();
    }

    public ActionResult Edit(Guid id)
    {
        var recipe = recipes.FindById(id);
        return View(recipe);
    }

    [HttpPost]
    public IActionResult Edit(Recipe editedRecipe)
    {
        if (ModelState.IsValid)
        {
            recipes.Update(editedRecipe);
            return RedirectToAction(nameof(List));
        }
        return View(editedRecipe);
    }

    public ActionResult Remove(Guid recipeId)
    {
        throw new NotImplementedException();
    }
}