using System;
using System.Collections.Generic;

public class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    //getters address.
    public string GetAddress()
    {
        return _address;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

    //setters to the Address.

    public void SetAddress(string address)
    {
        _address = address;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    //Method to get the complete Address.
    public string GetCompleteAddress()
    {
        return $"{_address}\n{_city}, {_state}\n{_country}";
    }

    //Method to verify if the address is in USA.
    public bool IsUSA()
    {
        return _country.ToLower() == "usa.";
    }

}