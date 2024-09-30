// Модель товару
public class Product
{
    public int Id { get; set; }  // Ідентифікатор товару
    public string Name { get; set; }  // Назва товару
    public decimal Price { get; set; }  // Ціна товару
    public bool IsBlocked { get; set; }  // Чи заблокований товар
    public int CategoryId { get; set; }  // Ідентифікатор категорії
}
