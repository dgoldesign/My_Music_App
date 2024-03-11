using NAudio.Wave;

public class MusicPlayer
{
    private readonly WaveOutEvent outputDevice = new WaveOutEvent();
    private AudioFileReader audioFile;

    public void Play(string filePath)
    {
        Stop(); // Stop any currently playing music
        audioFile = new AudioFileReader(filePath);
        outputDevice.Init(audioFile);
        outputDevice.Play();
    }

    public void Pause()
    {
        outputDevice.Pause(); // Pause the playback
    }

    public void Stop()
    {
        if (outputDevice != null)
        {
            outputDevice.Stop();
            outputDevice.Dispose();
        }
        if (audioFile != null)
        {
            audioFile.Dispose();
        }
    }
}
