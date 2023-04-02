using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageReplacement;

public class StorageContainer : IDisposable
{
    private string _path;

    public StorageContainer(string path) => _path = path;

    public void DeleteFile(string fileName) => File.Delete(Path.Combine(_path, fileName));

    public void Dispose()
    {
    }

    public bool FileExists(string testFilename) => File.Exists(Path.Combine(_path, testFilename));

    public string[] GetFileNames(string pattern) => Directory.GetFiles(_path, pattern);

    public Stream OpenFile(string fileName, FileMode mode) => File.Open(Path.Combine(_path, fileName), mode);
}

public class StorageDevice
{
    public StorageDevice(string path)
    {
        Path = path;
    }

    public string Path { get; }
    public bool IsConnected => true;

    public Task<StorageContainer> OpenAsync(string saveGameContainerName) => Task.FromResult(new StorageContainer(System.IO.Path.Combine(Path, saveGameContainerName)));

    public static void ShowSelector() { }
}

public class GamerServicesComponent : GameComponent
{
    public GamerServicesComponent(Game game) : base(game)
    {
    }
}
