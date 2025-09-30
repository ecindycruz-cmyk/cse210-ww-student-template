using System;
using System.Collections.Generic;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // getters to name and address
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }

    //setters to name and address.
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    //Method to verify is the customer is a USA resident.

    public bool IsResidentUSA()
    {
        return _address.IsUSA();
    }
}