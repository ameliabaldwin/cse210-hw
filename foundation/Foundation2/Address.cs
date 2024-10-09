using System;

public class Address
{
    private string streetAddress;
    private string city;
    private string stateOrProvince;
    private string country;

    private bool isFromUSA;


    public Address(string _streetAddress, string _city, string _stateOrProvince, string _country)
    {
        streetAddress = _streetAddress;
        city = _city;
        stateOrProvince = _stateOrProvince;
        country = _country;
        isFromUSA = false;

    }
    public bool AreYouAmerican()
    {
        if(country == "USA"||country == "United States of America")
        {
            isFromUSA = true;
        }
        else
        {
            isFromUSA = false;
        }
        return isFromUSA;
    }

    public string GetAddress()
    {
        return $"{streetAddress}\n{city}\n{stateOrProvince}\n{country}";
    }


}