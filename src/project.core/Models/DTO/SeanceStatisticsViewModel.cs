using System.ComponentModel.DataAnnotations;

namespace project.core.Models.DTO;

public class SeanceStatisticsViewModel
{
    public int SeanceId { get; set; }
    [Display(Name = "Movie Name")]
    public string MovieName { get; set; }
    [Display(Name = "Total Tickets Sold")]
    public int TotalTicketsSold { get; set; }
    [Display(Name = "Total Revenue")]
    public int TotalRevenue { get; set; }
    public List<TicketSaleDetails> TicketsSoldDetails { get; set; }
}
