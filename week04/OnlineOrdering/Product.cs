using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private string _id;
    private decimal _price;
    private int _quantity;

    public Product(string name, string id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    //getters to product.
    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    //setters to the product.
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetId(string id)
    {
        _id = id;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    //Method to calculate the total cost of the product.
    public decimal CalculateCostTotal()
    {
        return _price*_quantity;
    }
}