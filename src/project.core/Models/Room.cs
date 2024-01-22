using System.ComponentModel.DataAnnotations;

namespace project.core.Models;

public class Room
{

    public int Id { get; set; }
    [MaxLength(50,ErrorMessage="Name must be less than 50 characters")]
    [Display(Name = "Room Name")]
    public string Name { get; set; }
    [Display(Name = "Room Capacity")]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public int Capacity { get; set; }

}