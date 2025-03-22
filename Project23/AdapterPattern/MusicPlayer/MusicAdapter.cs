using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.MusicPlayer
{
    public class MusicAdapter : WavPlayer, IMusicPlayer
    {

        public void PlayMp3()
        {
            Console.WriteLine("Converting MP3 to WAV...");
            PlayWav();
        }
    }
}