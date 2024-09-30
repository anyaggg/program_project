namespace program_project.Data  // Простір імен повинен збігатися
{
    public class ProductManager
    {
        private List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);

            if (existingProduct != null)
            {
                Console.WriteLine("Продукт з таким ID вже існує.");
            }
            else
            {
                products.Add(product);
                Console.WriteLine($"Продукт '{product.Name}' успішно додано.");
            }
        }

        public Product GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Console.WriteLine($"Продукт знайдено: {product.Name}, ціна: {product.Price}");
                return product;
            }
            else
            {
                Console.WriteLine($"Продукт з ID {id} не знайдено.");
                return null;
            }
        }


        public void UpdateProduct(Product product)
        {
            var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);

            if (existingProduct != null)
            {
                // Оновлення полів продукту
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                Console.WriteLine($"Продукт з ID {product.Id} успішно оновлено.");
            }
            else
            {
                Console.WriteLine($"Продукт з ID {product.Id} не знайдено для оновлення.");
            }
        }

        public void DeleteProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Продукт з ID {id} успішно видалено.");
            }
            else
            {
                Console.WriteLine($"Продукт з ID {id} не знайдено для видалення.");
            }
        }

        public List<Product> GetAllProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Немає жодного продукту.");
            }
            else
            {
                Console.WriteLine("Отримано всі продукти:");
                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Ціна: {product.Price}");
                }
            }

            return products;
        }
    }
}
