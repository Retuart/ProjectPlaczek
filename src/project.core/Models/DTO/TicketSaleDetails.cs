using System.ComponentModel.DataAnnotations;

namespace project.core.Models.DTO;

public class TicketSaleDetails
{
    [Display(Name = "Ticket Name")]
    public string TicketName { get; set; }
    [Display(Name = "Quantity Sold")]
    public int QuantitySold { get; set; }
    [Display(Name = "Revenue")]
    public int Revenue { get; set; }
}
