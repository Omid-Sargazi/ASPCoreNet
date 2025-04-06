namespace StartegyPattern.AdapterPattern
{
    public class Mp3Player : IMediaPlayer
    {
        public void Play()
        {
            Console.WriteLine("Playing MP3 file.");
        }
    }
}