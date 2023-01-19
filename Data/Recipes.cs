namespace CrudInMvc;

public class Recipes
{
    readonly List<Recipe> recipes = new();

    public IEnumerable<Recipe> List()
    => recipes;
    
    public Recipe FindById(Guid recipeId)
    => recipes.Single(recipe => recipe.ID == recipeId);

    public void Add(Recipe recipe)
    => recipes.Add(recipe);

    public void Update(Recipe newRecipe)
    {
        var oldRecipe = recipes.Single(r => r.ID == newRecipe.ID);

        oldRecipe.Name = newRecipe.Name;
        oldRecipe.Ingredients = newRecipe.Ingredients;
        oldRecipe.Instructions = newRecipe.Instructions;
    }

    public void Remove(Guid recipeId)
    => recipes.Remove(FindById(recipeId));
}