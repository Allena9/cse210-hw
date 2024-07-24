using System;

public class ShoppingCart
{
    private List<Order> _orders;
    private Random _ran;
    public ShoppingCart()
    {
        _orders = new();
        _ran = new();
    }

    public void Checkout()
    {
        Console.Clear();

        CreateOrders();

        DisplayOrders();
    }

    public void CreateOrders()
    {
        int numOrders = _ran.Next(2,4);

        for(int i = 0; i < numOrders; i++)
        {
            Order ord = new(CreateCustomer());

            _orders.Add(ord);
        }

        AddProducts();
    }

    public void AddProducts()
    {
        List<string> possNames = ["Banana", "Apple", "PopTart"];
        List<int> possIDs = [1, 2, 3];
        List<double> possPrices = [1.50, 1.0, 4.0];
        List<int> possQuantities = [1, 3, 5];

        foreach(Order order in _orders)
        {
            int numProducts = _ran.Next(1,4);

            for(int x = 0; x <= numProducts; x++)
            {
                int temp = _ran.Next(0,3);
                Product prod = new(possNames[temp], possIDs[temp], possPrices[temp], possQuantities[_ran.Next(0,3)]);
                order.AddProduct(prod);
            }
        }
    }

    public void DisplayOrders()
    {
        foreach(Order order in _orders)
        {
            Console.WriteLine($"Order Total: {order.TotalPrice()}\n \nPacking Label:\n{order.PackingLabel()}\nShipping Label:\n{order.ShippingLabel()}\n \n");
        }
    }

    public Customer CreateCustomer()
    {
        List<string> names = ["George Lopez", "Jeff Bloom", "Bob Builder"];
        List<string> streetAddress = ["20 Cooper Square", "6 Metrotech Center", "9th St. PATH Station"];
        List<string> city = ["Rexburg", "Los Angeles", "Seattle"];
        List<string> state = ["ID", "CA", "WA"];
        List<string> country = ["USA", "Canada"];

        Customer cust = new(names[_ran.Next(0,3)], streetAddress[_ran.Next(0,3)], city[_ran.Next(0,3)], state[_ran.Next(0,3)], country[_ran.Next(0,2)]);
        
        return cust;
    }
}