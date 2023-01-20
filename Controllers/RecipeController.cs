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
        throw new NotImplementedException();
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