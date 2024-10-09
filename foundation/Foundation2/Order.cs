using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private Customer customer;
    private List<Product> products;
    private Discount discount;
    private Address address;

    public Order(Customer _customer, Discount _discount, Address _address)
    {
        customer = _customer;
        products = new List<Product>();
        discount = _discount;
        address = _address;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public float GetTotal()
    {
        float total = 0;
        foreach (var product in products)
        {
            total += product.GetPrice() * product.GetQuantity();
        }
        if (discount.IsValidCode())
        {
            total -= total * discount.GetDiscountPercent();
        }
        // Checks if the user is from USA
        if (address.AreYouAmerican())
        {
            // Adds shipping cost for USA citizens
            total += 5;
        }
        else
        {
            // Adds shipping cost for citizens who are out of the USA
            total += 35;
        }

        return total;
    }

    public string DisplayOrderDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(customer.GetCustomer());
        sb.AppendLine("Products:");
        foreach (var product in products)
        {
            sb.AppendLine(product.GetProductInfo());
        }
        sb.AppendLine($"Discount: {discount.GetDiscountPercentAsString()}");
        sb.AppendLine($"Total: {GetTotal():C}");
        return sb.ToString();
    }
}
