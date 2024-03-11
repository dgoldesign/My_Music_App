namespace Music_player_app
{
    public class Playlist
    {
        public List<Music> songs = new List<Music>();
        public MusicPlayer musicPlayer = new MusicPlayer();
        private Random random = new Random();

        public Playlist()
        {
            // Add predefined songs to the playlist
            AddSong("Walking in The Spirit", "Apst Edu", "C:\\Users\\HP\\Downloads\\Telegram Desktop\\Walking in The Spirirt 1.mp3");
            AddSong("Walking in the Spirit", "Apst Edu", "C:\\Users\\HP\\Downloads\\Telegram Desktop\\Walking in the Spirit 8.mp3");
            AddSong("War Cry", "Chinedu Ndubueze", "C:\\Users\\HP\\Music\\WAR_CRY__CHINEDU_NDUBUEZE(128k).mp3");
            AddSong("We Behold", "Abbey Ojomu", "C:\\Users\\HP\\Music\\Abbey_Ojomu_-_We_Behold_Qavah_Anthem_.mp3");


            // Add more songs as needed
        }

        // Method to add a song to the playlist
        private void AddSong(string title, string artist, string filePath)
        {
            Music newSong = new Music
            {
                Title = title,
                Artist = artist,
                FilePath = filePath
            };
            songs.Add(newSong);
        }

        // Method to play a song
        public void PlaySong(int index)
        {
            if (index >= 0 && index < songs.Count)
            {
                Music songToPlay = songs[index];
                musicPlayer.Play(songToPlay.FilePath);
            }
            else
            {
                Console.WriteLine("Invalid song index");
            }
        }

        // Method to pause the currently playing song
        public void PauseSong()
        {
            musicPlayer.Pause();
            Console.WriteLine("Song paused.");
        }

        // Method to shuffle the playlist
        public void ShufflePlaylist()
        {
            int n = songs.Count;
            while (n > 1)
            {
                int k = random.Next(0, n);
                n--;
                Music temp = songs[n];
                songs[n] = songs[k];
                songs[k] = temp;
            }
        }

        // Method to sort the playlist by title
        public void SortByTitle()
        {
            songs.Sort((x, y) => string.Compare(x.Title, y.Title));
        }

        // Method to sort the playlist by artist
        public void SortByArtist()
        {
            songs.Sort((x, y) => string.Compare(x.Artist, y.Artist));
        }

        // Method to remove a song from the playlist
        public void RemoveSong(int index)
        {
            if (index >= 0 && index < songs.Count)
            {
                songs.RemoveAt(index);
                Console.WriteLine("Song removed from the playlist.");
            }
            else
            {
                Console.WriteLine("Invalid song index");
            }
        }
    }
}
