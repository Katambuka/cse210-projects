using System;
class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string state, string zip, string country)
    {
        Street = street;
        City = city;
        State = state;
        Zip = zip;
        Country = country;
    }

    public override string ToString()
    {
        return $"{Street}\n{City}, {State} {Zip}\n{Country}";
    }
}
