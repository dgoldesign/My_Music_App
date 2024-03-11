namespace Music_player_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Playlist playlist = new Playlist();
            UserInteraction userInteraction = new UserInteraction(playlist);
            userInteraction.Start();
        }
    }
}
