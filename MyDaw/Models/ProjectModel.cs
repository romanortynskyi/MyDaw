using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace MyDaw.Models;

public partial class ProjectModel : ObservableObject
{
    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _location;

    [ObservableProperty]
    private int _defaultTempo;

    [ObservableProperty]
    private int _defaultMeterUpper;

    [ObservableProperty]
    private int _defaultMeterLower;

    [ObservableProperty]
    private int _bitDepth;

    [ObservableProperty]
    private int _sampleRate;

    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }


    public ProjectModel() { }

    public ProjectModel(ProjectModel project)
    {
        Name = project.Name;
        Location = project.Location;
        DefaultTempo = project.DefaultTempo;
        DefaultMeterUpper = project.DefaultMeterUpper;
        DefaultMeterLower = project.DefaultMeterLower;
        BitDepth = project.BitDepth;
        SampleRate = project.SampleRate;
    }
}
