using System.Dynamic;
using System.Net;

class Order{
    public int OrderID { get; private set; }
    public string Time { get; private set; }
    public DateTime OrderDate { get; private set; }
    public Customer Customer { get; private set; }
    public Clerk Clerk { get; private set; }   
    public List<Item> Items { get; }
    public OrderStatus Status { get; private set;}

    public enum OrderStatus{
        InPreparation,
        InDelivery,
        Closed

    };

    public Order (int OrderID, string Time, Customer Customer, Clerk Clerk, List<Item> Items){
        this.OrderID = OrderID;
        this.Time = Time;
        this.OrderDate = DateTime.Now;
        this.Customer = Customer;
        this.Clerk = Clerk;
        this.Items = Items;
        Status = OrderStatus.InPreparation;
    }
}