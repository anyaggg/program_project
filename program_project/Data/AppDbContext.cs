using System.Collections.Generic;
using program_project.Models;

// Контекст бази даних
public class AppDbContext
{
    public List<Category> Categories { get; set; } = new List<Category>();  // Список категорій
    public List<Product> Products { get; set; } = new List<Product>();  // Список товарів
    public List<User> Users { get; set; } = new List<User>();  // Список користувачів
}
