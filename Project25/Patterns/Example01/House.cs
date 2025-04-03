namespace Patterns.Example01
{
    public class House
    {
        public List<Room> Rooms {get; set;}
        public string Address {get; set;}

        public House(string address)
        {
            Address = address;

            Rooms = new List<Room>()
            {
               new Room {"24", 2},
               new Room {"53", 2},
               new Room {"27", 4},
            }
        }

        public void AddRoom(string name, int capacity)
        {
            Rooms.Add(new Room(name, capacity));
        }
    }
}