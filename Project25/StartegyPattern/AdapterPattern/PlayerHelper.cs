namespace StartegyPattern.AdapterPattern
{
    public class PlayerHelper 
    {
        public void Play()
        {
            var oldPlaye = new OldVlcPlayer();
            oldPlaye.StartPlayback();
        }
    }
}