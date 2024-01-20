using System;

namespace project.core.Models;

public class Seance
{

    public int id { get; set; }
    public int id_movie { get; set; }
    public virtual Movie movie { get; set; }
    public DateTime start { get; set; }
    public DateTime end() { return start.AddMinutes(movie.duration); }
    public int id_room { get; set; }
    public virtual Room room { get; set; }
    
}
