namespace CrudInMvc;

public class Recipes
{
    readonly List<Recipe> recipes = new(){
        new(){
            Name = "Cutlet",
            Ingredients = @"4 potatoes
250 grams mined meat
2 eggs
1 onion
1 teaspoon turmeric
Oil as much as required
Salt pepper and turmeric as much as required",
            Instructions = @"Peel off the potatoes and grate them.
Peel off the onions and grate them in a separate bowl because we need to remove the extra juice of the onions. Then add the grated onions to the grated potatoes.
Now add the minced meat, the eggs, some salt, pepper and turmeric
Use your hands to strongly mix all the ingredients. After that, a consistent combination will be reached.
Next, add some oil in a frying pan and wait for it to be heated. meanwhile, use your hands to give the Kotlet oval shapes before frying them. Try to make same oval shapes so that the dish will look more beautiful
Fry them then in a pan. When one side is cooked, turn them upside down and let the other side fry completely as well."
        }
    };

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