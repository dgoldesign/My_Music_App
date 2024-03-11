using System;

namespace Music_player_app
{
    public class UserInteraction
    {
        private Playlist playlist;

        public UserInteraction(Playlist playlist)
        {
            this.playlist = playlist;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the Music Player App!");

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Play a song");
                Console.WriteLine("2. Pause the current song");
                Console.WriteLine("3. Shuffle the playlist");
                Console.WriteLine("4. Remove a song from the playlist");
                Console.WriteLine("5. Sort the playlist by title");
                Console.WriteLine("6. Sort the playlist by artist");
                Console.WriteLine("7. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        PlaySong();
                        break;
                    case "2":
                        PauseSong();
                        break;
                    case "3":
                        ShufflePlaylist();
                        break;
                    case "4":
                        RemoveSong();
                        break;
                    case "5":
                        SortByTitle();
                        break;
                    case "6":
                        SortByArtist();
                        break;
                    case "7":
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        private void PlaySong()
        {
            Console.WriteLine("Select a song to play:");
            for (int i = 0; i < playlist.songs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playlist.songs[i].Title} - {playlist.songs[i].Artist}");
            }

            Console.WriteLine("Enter the number of the song you want to play: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 1 && index <= playlist.songs.Count)
                {
                    playlist.PlaySong(index - 1);
                }
                else
                {
                    Console.WriteLine("Invalid song index.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private void PauseSong()
        {
            playlist.PauseSong();
        }

        private void ShufflePlaylist()
        {
            playlist.ShufflePlaylist();
            Console.WriteLine("Playlist shuffled successfully.");
        }

        private void RemoveSong()
        {
            Console.WriteLine("Enter the index of the song you want to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                playlist.RemoveSong(index - 1);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        private void SortByTitle()
        {
            playlist.SortByTitle();
            Console.WriteLine("Playlist sorted by title.");
        }

        private void SortByArtist()
        {
            playlist.SortByArtist();
            Console.WriteLine("Playlist sorted by artist.");
        }
    }
}
