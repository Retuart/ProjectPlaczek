using System;
using System.ComponentModel.DataAnnotations;

namespace project.core.Models;

public class Seance
{

    public int Id { get; set; }
    public int Id_movie { get; set; }
    public virtual Movie? Movie { get; set; }
    public int Id_room { get; set; }
    [Display(Name = "Room Name")]
    public virtual Room? Room { get; set; }
    public int[]? OrdersIds { get; set; }
    public ICollection<Order>? Orders { get; set; }

    [Display(Name = "Start Time")]
    public DateTime Start { get; set; }
    public DateTime End() { return Start.AddMinutes(Movie.Duration); }
    public int FreeSpace() { return Room.Capacity - Orders?.Sum(o => o?.TicketCount() ) ?? Room.Capacity; }
    public string MovieName() { return Movie.Title; }
}
