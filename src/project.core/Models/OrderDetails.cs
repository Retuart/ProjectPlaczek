using System.ComponentModel.DataAnnotations;

namespace project.core.Models;

public class OrderDetails 
{

    public int Id { get; set; }
    [Display(Name = "Ticket Name")]
    public int TicketId { get; set; }
    public virtual Ticket? Ticket { get; set; }
    public int OrderId { get; set; }
    public virtual Order? Order { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    [Display(Name = "Ticket Count")]
    public int Count { get; set; }
    public int PriceSum() { return Ticket.Price * Count; }
}