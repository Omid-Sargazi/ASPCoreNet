namespace Patterns.Example01
{
    public class Patient
    {
        public string Name { get; set; }
    public string Illness { get; set; }
    
    public void VisitDoctor(Doctor doctor)
    {
        Console.WriteLine($"{Name} به دکتر {doctor.Name} مراجعه کرد.");
    }
    }
}