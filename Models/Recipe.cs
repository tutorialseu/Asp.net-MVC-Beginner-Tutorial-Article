namespace CrudInMvc;

public class Recipe
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public string Ingredients { get; set; }
    public string Instructions { get; set; }
}