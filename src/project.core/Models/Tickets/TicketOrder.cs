namespace project.core.Models;

public class TicketOrder 
{

    public int Id { get; set; }
    public int TicketId { get; set; }
    public virtual Ticket Ticket { get; set; }
    public int Count { get; set; }
    public int PriceSum() { return Ticket.Price * Count; }
}