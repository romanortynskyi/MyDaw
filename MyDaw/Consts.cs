namespace MyDaw;

public class Consts
{
    public static string GetDefaultProjectsDirectoryPath()
    {
        string systemDirectoryPath = Path.GetPathRoot(Environment.SystemDirectory);
        string path = Path.Combine(systemDirectoryPath, "MyDaw Projects");

        return path;
    }

    public const int DefaultTempo = 120;
    public const int DefaultMeterUpper = 4;
    public const int DefaultMeterLower = 4;
    public const int DefaultBitDepth = 16;
    public const int DefaultSampleRate = 44100;
}
