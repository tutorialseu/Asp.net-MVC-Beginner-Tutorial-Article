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
        var newRecipe = new Recipe() { ID = Guid.NewGuid() };
        return View(newRecipe);
    }

    [HttpPost]
    public IActionResult Add(Recipe newRecipe)
    {
        if (ModelState.IsValid)
        {
            recipes.Add(newRecipe);
            return RedirectToAction(nameof(List));
        }
        return View(newRecipe);
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