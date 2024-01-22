using System.ComponentModel.DataAnnotations;

namespace project.core.Models;

public class Movie
{

    public int Id { get; set; }
    [MaxLength(50,ErrorMessage = "Name must be less than 50 characters")]
    [Display(Name = "Movie Title")]
    public string Title { get; set; }
    [MaxLength(200,ErrorMessage = "Description must be less than 200 characters")]
    [Display(Name = "Description")]
    public string Description { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    [Display(Name = "Movie Lenght (minutes)")]
    public int Duration { get; set; }
    public string Image { get; set; }


}