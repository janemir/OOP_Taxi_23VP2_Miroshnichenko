namespace OOP_Taxi_23VP2.Models;

public class DbOrder
{
    public int Id { get; set; }
    public string DriverName { get; set; }
    public string CarNumber { get; set; }
    public string ClientPhone { get; set; }
    public string OrderStatus { get; set; }
}

public class Order
{
    public string DriverName { get; set; }
    public string CarNumber { get; set; }
    public string ClientPhone { get; set; }
    public string OrderStatus { get; set; }
}
