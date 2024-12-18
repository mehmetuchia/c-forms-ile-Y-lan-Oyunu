using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace yılannnn
{
    public class MusicManager 
    {
        private static MusicManager _instance;
        private SoundPlayer player;
        private bool isPlaying;
        // Singleton örneği
        public static MusicManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MusicManager();
                }
                return _instance;
            }
        }
        private MusicManager()
        {
            player = new SoundPlayer("mzk.wav"); // Müzik dosyası yolunu girin
            isPlaying = false; // İlk durumda müzik çalmıyor
        }

        // Müziği başlat
        public void StartMusic()
        {
            if (!isPlaying)
            {
                player.PlayLooping();
                isPlaying = true;
            }
        }

        // Müziği durdur
        public void StopMusic()
        {
            if (isPlaying)
            {
                player.Stop();
                isPlaying = false;
            }
        }
        public bool IsPlaying()
        {
            return isPlaying;
        }
    }
}
