namespace MyDaw.Models;

public class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string Location { get; set; } = Consts.GetDefaultProjectsDirectoryPath();
    public string AudioPath { get; set; } = "";
    public int DefaultTempo { get; set; } = 120;
    public int DefaultMeterUpper { get; set; } = 4;
    public int DefaultMeterLower { get; set; } = 4;
    public int BitDepth { get; set; } = 16;
    public int SampleRate { get; set; } = 44100;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Project() { }

    public Project(Project project)
    {
        Name = project.Name;
        Location = project.Location;
        AudioPath = project.AudioPath;
        DefaultTempo = project.DefaultTempo;
        DefaultMeterUpper = project.DefaultMeterUpper;
        DefaultMeterLower = project.DefaultMeterLower;
        BitDepth = project.BitDepth;
        SampleRate = project.SampleRate;
    }
}
