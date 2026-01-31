public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public void PrintAddress()
    {
        Console.WriteLine(_street);
        Console.WriteLine($"{_city}, {_state}");
        Console.WriteLine(_country);
    }

    public bool IsUSAddress()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";
    }
}