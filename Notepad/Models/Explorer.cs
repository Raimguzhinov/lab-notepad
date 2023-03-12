using System.IO;

namespace Notepad.Models;
public abstract class Explorer
{
    public Explorer(string name)
    {
        Header = name;
    }

    public string Header { get; set; }
    public string Image { get; set; } = null!;
    public string SourceName { get; set; } = null!;
}

public class Files : Explorer
{
    public Files(string name) : base(name)
    {
        SourceName = name;
        Image = "Assets/iconFile.png";
    }

    public Files(FileInfo fileName) : base(fileName.Name)
    {
        SourceName = fileName.FullName;
        Image = "Assets/iconFile.png";
    }
}

public class Directories : Explorer
{
    public Directories(string name) : base(name)
    {
        SourceName = name;
        Image = "Assets/iconFolder.png";
    }

    public Directories(DirectoryInfo directoryName) : base(directoryName.Name)
    {
        SourceName = directoryName.FullName;
        Image = "Assets/iconFolder.png"; 
    }
}