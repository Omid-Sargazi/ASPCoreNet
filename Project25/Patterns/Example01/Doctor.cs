namespace Patterns.Example01
{
    public class Doctor
    {
        public string Name {get; set;}
        public string Specialty { get; set; }

        public void TreatPatient(Patint patient)
        {
            Console.WriteLine($"{Name} is treating {patient.Name}.");
        }
    }
}