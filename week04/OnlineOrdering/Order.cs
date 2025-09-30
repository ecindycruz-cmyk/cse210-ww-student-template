using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }
    //Getters of List of product and customer.
    public List<Product> GetProducts()
    {
        return _products;
    }
    public Customer GetCustomer()
    {
        return _customer;
    }
    //Setters of List of product and customer.
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    //Method to Add products to the Order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    //Method for calculating the total cost of the order.
    public decimal CalculateCostTotal()
    {
        decimal costTotal = 0;
        foreach (Product product in _products)
        {
            costTotal += product.CalculateCostTotal();
        }
        decimal costshipping = _customer.IsResidentUSA() ? 5 : 35;
        return costTotal + costshipping;
    }
    //Method to Get the packaging label.
    public string GetPackagingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} ({product.GetId()})\n";
        }
        return label;
    }
    //Method to Get the shipping label.
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetCompleteAddress()}";
    }
}