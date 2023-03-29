using System;
class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public Address(string streetAddress, string city, string state, string zipCode)
    {
        this.StreetAddress = streetAddress;
        this.City = city;
        this.State = state;
        this.ZipCode = zipCode;
    }

    public string GetFullAddress()
    {
        return $"{this.StreetAddress}, {this.City}, {this.State} {this.ZipCode}";
    }
}
