namespace StartegyPattern.AdapterPattern
{
    public class PlayerHelper : IMediaPlayer
    {
        private OldVlcPlayer _oldVlcPlayer;
        public PlayerHelper(OldVlcPlayer oldVlcPlayer)
        {
            _oldVlcPlayer = oldVlcPlayer;
        }
        public void Play()
        {
           _oldVlcPlayer.StartPlayback();
        }
    }
}