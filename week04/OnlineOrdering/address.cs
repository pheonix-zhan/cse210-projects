public class Address
{
private string _street;
private string _city;
private string _state;
private string _country;

public Address(string street, string city, string state, string country)
    {
        street = _street;
        city = _city;
        state = _state;
        country = _country;
    }

public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA" || _country.Trim().ToUpper() == "UNITED STATES";
    }

public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}