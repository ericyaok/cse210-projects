using System;

public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;


    public Product(string name, string productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetPrice()
    {
        return _price;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double CalcCost()
    {
        return _price * _quantity;
    } 

}