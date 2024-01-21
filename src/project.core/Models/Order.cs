namespace project.core.Models;

public class Order 
{

    public int Id { get; set; }
    public int[]? OrderDetailsIds { get; set; }
    public virtual OrderDetails[]? OrderDetails { get; set; }
    public int SeanceId { get; set; }
    public virtual Seance Seance { get; set; }

    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    public int PriceSum() { return OrderDetails.Sum(o => o.PriceSum()); }
    public int TicketCount() { return OrderDetails.Sum(o => o.Count); }

}