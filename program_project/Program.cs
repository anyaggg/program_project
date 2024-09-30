using program_project.Data;

class Program
{
    static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager();

        // Створюємо продукти
        Product product1 = new Product { Id = 1, Name = "Телефон", Price = 599.99m };
        Product product2 = new Product { Id = 2, Name = "Ноутбук", Price = 1200.00m };

        // Додавання продуктів
        productManager.AddProduct(product1);
        productManager.AddProduct(product2);

        // Отримання продукту
        productManager.GetProduct(1);

        // Оновлення продукту
        product1.Price = 550.00m;
        productManager.UpdateProduct(product1);

        // Видалення продукту
        productManager.DeleteProduct(2);

        // Отримання всіх продуктів
        productManager.GetAllProducts();
    }
}
