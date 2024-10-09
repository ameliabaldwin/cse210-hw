using System;

public class Customer
{
    private string name;
    private Address address;

    public Customer (string _name, Address _address)
    {
        name = _name;
        address = _address;
    }

    public string GetCustomer()
    {
        return $"{name}\n{address.GetAddress()}";
    }

}