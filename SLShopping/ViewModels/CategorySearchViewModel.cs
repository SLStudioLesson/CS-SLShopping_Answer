using SLShopping.Models;

namespace SLShopping.ViewModels;

public class CategorySearchViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Category> Results { get; set; }
}