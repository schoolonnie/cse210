public class Order
{
    private Customer _customer;
    private List<Product> _products;

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
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        if (_customer.IsInUSA())
        {
            total += 5.00; // Shipping fee for USA
        }
        else
        {
            total += 35.00; // Shipping fee for international
        }
        return total;
    }

    public void PrintPackingLabel()
    {
        Console.WriteLine("+==========================+");
        Console.WriteLine("Packing Label:");
        foreach (var product in _products)
        {
            product.PrintLabel();
        }
        Console.WriteLine("+==========================+");
    }

    public void PrintShippingLabel()
    {
        Console.WriteLine("+==========================+");
        Console.WriteLine("Shipping Label:");
        _customer.PrintAddress();
        Console.WriteLine("+==========================+");
    }
}