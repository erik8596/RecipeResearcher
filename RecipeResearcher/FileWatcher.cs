using FinalProjectGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileWatcher
{
    private FileSystemWatcher _fileWatcher;
    private List<FileObserver> _observers;

    public FileWatcher(string path)
    {
        _observers = new List<FileObserver>();
        _fileWatcher = new FileSystemWatcher(Path.GetDirectoryName(path))
        {
            Filter = Path.GetFileName(path),
            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.FileName
        };

        _fileWatcher.Changed += OnFileChanged;
        _fileWatcher.EnableRaisingEvents = true;
    }

    private void OnFileChanged(object sender, FileSystemEventArgs e)
    {
        NotifyObservers();
    }

    public void RegisterObserver(FileObserver observer)
    {
        if (!_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void UnregisterObserver(FileObserver observer)
    {
        _observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public void StopWatching()
    {
        _fileWatcher.EnableRaisingEvents = false;
        _fileWatcher.Dispose();
    }
}
