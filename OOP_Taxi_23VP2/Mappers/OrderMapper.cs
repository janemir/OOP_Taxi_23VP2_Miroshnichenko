using System.Runtime.Remoting.Metadata.W3cXsd2001;
using OOP_Taxi_23VP2.Models;

namespace OOP_Taxi_23VP2.Mappers;

public static class OrderMapper
{
    public static Order MapToOrder(DbOrder dbOrder)
    {
        return new Order
        {
            DriverName = dbOrder.DriverName,
            CarNumber = dbOrder.CarNumber,
            ClientPhone = dbOrder.ClientPhone,
            OrderStatus = dbOrder.OrderStatus
        };
    }
}