namespace project.core.Models;

public class Order 
{

    public int Id { get; set; }
    public int[] TicketOrderIds { get; set; }
    public virtual TicketOrder[] TicketOrders { get; set; }
    public int PriceSum() { return TicketOrders.Sum(o => o.PriceSum()); }
    public int TicketCount() { return TicketOrders.Sum(o => o.Count); }
}