using System;

public class Order
{
    private Customer _customer;
    private List<Product> _productList = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _productList = products;
    }

    public double CalcTotalCost()
    {
        int shippingCost;
        double totalCost = 0;

        if (_customer.IsUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        foreach (Product product in _productList)
        {
            totalCost = totalCost + product.CalcCost();
        }

        return totalCost + shippingCost;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _productList)
        {
            Console.WriteLine($"Product name: {product.GetProductName()}, Product ID: {product.GetProductID()}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }

}