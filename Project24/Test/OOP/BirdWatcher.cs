namespace Test.OOP{
    public class BirdWatcher
    {
        public void Watch(Bird bird)
    {
        bird.Fly(); // 💥 This will throw an exception if it's a Penguin!
    }
    }
}