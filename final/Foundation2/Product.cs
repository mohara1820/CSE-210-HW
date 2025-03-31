public class Product
{
    private string name;
    private string productId;
    private decimal pricePerUnite;
    private int quantity;

    public Product(string name, string productId, decimal pricePerUnite, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnite = pricePerUnite;
        this.quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return pricePerUnite*quantity;
    }

    public string GetPackingLabel()
    {
        return $"{name} (ID: {productId})";
    }
}