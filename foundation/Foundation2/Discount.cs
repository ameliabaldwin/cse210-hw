using System;

public class Discount
{
    private string discountCode;
    private float discountPercent;
    private bool validCode;

    public Discount(string _discountCode, float _discountPercent)
    {
        discountCode = _discountCode;
        discountPercent = _discountPercent;
        validCode = false;

    }

    public string GetDiscountCode()
    {
        return discountCode;
    }

    public bool IsValidCode()
    {
        if(discountCode == "GET20OFFSALE")
        {
            validCode = true;
        }
        else
        {
            validCode = false;
        }
        return validCode;

    }
    public float GetDiscountPercent()
    {
        if(IsValidCode())
        {
            discountPercent = .20f;
        }
        else
        {
            discountPercent = 0.00f;
        }
        return discountPercent;
    }
    public string GetDiscountPercentAsString()
    {
        if(IsValidCode())
        {
            return $"{discountPercent * 100}%";
        }
        else
        {
            return $"{0 * 100}%";
        }
            
    }

}