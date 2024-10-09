using System;

public class Product
{
    private string productName;
    private int productId;
    private int quantity;

    private float price;
    

    public Product(string _productName, int _productId, int _quantity, float _price)
    {
        productName = _productName;
        productId = _productId;
        quantity = _quantity;
        price = _price;
    }
    public string GetProductInfo()
    {
        return $"-{productName}({productId}): {quantity}x Price: {price}";
    }
    public int GetQuantity()
    {
        return quantity;
    }
    public float GetPrice()
    {
        return price;
    }

}