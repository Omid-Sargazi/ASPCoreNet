namespace Test.OOP
{
    public class Penguin
    {
        public override void Fly()
        {
            throw new NotSupportedException("Penguins can't fly!");
        }
    }
}