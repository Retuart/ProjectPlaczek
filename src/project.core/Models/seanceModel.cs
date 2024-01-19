using System;

namespace project.core.Models;

public class seanceModel
{

    public int id { get; set; }
    public int id_movie { get; set; }
    public virtual movieModel movie { get; set; }
    public DateTime start { get; set; }
    public DateTime end { get; set; }
    public int id_room { get; set; }
    public virtual roomModel room { get; set; }
    
}
