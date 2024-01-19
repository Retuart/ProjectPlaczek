namespace project.core.Models;

public class seanceModel
{

    public int id { get; set; }
    public int id_movie { get; set; }
    public virtual movieModel movie { get; set; }
    public datetime start { get; set; }
    public datetime end { get; set; }
    public int id_room { get; set; }
    
}
