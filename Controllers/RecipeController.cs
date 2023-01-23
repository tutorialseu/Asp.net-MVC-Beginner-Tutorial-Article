using Microsoft.AspNetCore.Mvc;

namespace CrudInMvc.Models;

public class RecipeController : Controller
{
    public ActionResult List()
    {
        var recipes = new Recipes().List();
        return View(recipes);
    }

    public ActionResult Details(Guid id)
    {
        var recipe = new Recipes().FindById(id);
        return View(recipe);
    }

    public ActionResult Add()
    {
        throw new NotImplementedException();
    }

    public ActionResult Update(Guid id)
    {
        throw new NotImplementedException();
    }

    public ActionResult Remove(Guid recipeId)
    {
        throw new NotImplementedException();
    }
}