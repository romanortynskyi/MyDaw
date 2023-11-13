namespace MyDaw;

public class Consts
{
    public static string GetDefaultProjectsDirectoryPath()
    {
        string systemDirectoryPath = Path.GetPathRoot(Environment.SystemDirectory);
        string path = Path.Combine(systemDirectoryPath, "MyDaw Projects");

        return path;
    }
}
