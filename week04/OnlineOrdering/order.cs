// Owns a list of products and a customer.
// Calculates total price, generates packing and shipping labels.
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Shipping cost based on customer location
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";

        foreach (Product product in _products)
        {
            label += $"  {product.GetPackingInfo()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"--- SHIPPING LABEL ---\n{_customer.GetShippingInfo()}";
    }

    public void Display()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${GetTotalPrice():F2}");
        Console.WriteLine("=================================================");
        Console.WriteLine();
    }
}