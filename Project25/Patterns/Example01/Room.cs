namespace Patterns.Example01
{
    public class Room
    {
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }

        public Room(string roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Room Number: {RoomNumber}, Capacity: {Capacity}");
        }
    }
}