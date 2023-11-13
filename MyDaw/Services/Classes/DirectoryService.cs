using MyDaw.Services.Interfaces;

namespace MyDaw.Services.Classes;

public class DirectoryService : IDirectoryService
{ 
    public void EnsureDirectoryExists(string path)
    {
        var directories = path.Split(Path.DirectorySeparatorChar);
        var currentPath = directories[0];

        for (var i = 1; i < directories.Length; i++)
        {
            currentPath = Path.Combine(currentPath, directories[i]);

            if (!Directory.Exists(currentPath))
            {
                Directory.CreateDirectory(currentPath);
            }
        }
    }
}
