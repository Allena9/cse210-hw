using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double total = 0;

        foreach(Product product in _products)
        {
            total += product.TotalCost();
        }

        if(_customer.IsUsa() == true)
        {
            total += 5.0;
            return total;
        }
        else
        {
            total += 35.0;
            return total;
        }
    }

    public string PackingLabel()
    {
        List<string> packingList = new();
        string label = "";

        foreach(Product product in _products)
        {
            packingList.Add(product.LabelFormat());
        }

        foreach(string product in packingList)
        {
            label += $"{product}\n";
        }

        return label;
    }

    public string ShippingLabel()
    {
        return _customer.LabelFormat();
    }
}