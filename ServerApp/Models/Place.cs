namespace ServerApp.Models
{
    public class Place
    {
       public string Name { get; private set; }
       public Coord Position { get; private set; }

       public Place(string name, Coord position)
       {
           Name = name;
           Position = position;
       }
    }
}
