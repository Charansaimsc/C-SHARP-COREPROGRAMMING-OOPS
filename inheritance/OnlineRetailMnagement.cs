using System;

public class Order
{
	public string OrderId { get; }
	public string OrderDate { get; }
	public Order(string orderId,string orderDate)
	{
		this.OrderId = orderId;
		this.OrderDate = orderDate;
	}
    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }

    public virtual void DisplayOrderStatus() 
	{
		Console.WriteLine($"OrderId : {OrderId}");
		Console.WriteLine($"OrderDate: {OrderDate}");
		 Console.WriteLine($"Status     : {GetOrderStatus()}");
	} 
}
public class ShippedOrder : Order
{
	public int TrackingNumber { get;  }
	public ShippedOrder( string orderId, string orderDate,int trackingNumber) : base(orderId, orderDate)
	{
		this.TrackingNumber = trackingNumber;
	}
    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
    public override void DisplayOrderStatus()
	{
		base.DisplayOrderStatus();
		Console.WriteLine($"Tracking number : {TrackingNumber}");
	}
}
public class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate{ get; }
    public DeliveredOrder(string DeliveryDate, string orderId,int TrackingNumber, string orderDate) : base(orderId, orderDate,TrackingNumber)
    {
        this.DeliveryDate = DeliveryDate;
    }
    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }
    public override void DisplayOrderStatus()
    {
        base.DisplayOrderStatus();
        Console.WriteLine($"Delivery Date : {DeliveryDate}");
    }
}
