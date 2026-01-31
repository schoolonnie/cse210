public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void PrintAddress()
    {
        Console.WriteLine($"Customer Name: {_name}");
        _address.PrintAddress();
    }

    public bool IsInUSA()
    {
        return _address.IsUSAddress();
    }
}