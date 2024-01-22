
using System.ComponentModel.DataAnnotations;

namespace project.core.Models;

public class Ticket 
{

    public int Id { get; set; }
    [MaxLength(50,ErrorMessage = "Name must be less than 50 characters")]
    [Display(Name = "Ticket Name")]
    public string Name { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    [Display(Name = "Ticket Price")]
    public int Price { get; set; }

}