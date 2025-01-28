class File
{
    private string _fileName;
    private string _fullPath;
    private long _fileSize;

    public File()
    {
        _fileName = "default.txt";
        _fullPath = "C:\\default\\default.txt";
        _fileSize = 0;
    }

    public File(string fileName, string fullPath, long fileSize)
    {
        FileName = fileName;
        FullPath = fullPath;
        FileSize = fileSize;
    }

    public string FileName
    {
        get => _fileName;
        set
        {
            if (value.Length < 1)
            {
                Console.WriteLine("Имя файла должно содержать хотя бы 1 символ.");
            }
            _fileName = value;
        }
    }

    public string FullPath
    {
        get => _fullPath;
        set
        {
            if (value.Length < 1)
            {
                Console.WriteLine("Полный путь должен содержать хотя бы 1 символ.");
            }
            _fullPath = value;
        }
    }

    public long FileSize
    {
        get => _fileSize;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Размер файла не может быть отрицательным.");
            }
            _fileSize = value;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Имя файла: {_fileName}");
        Console.WriteLine($"Полный путь: {_fullPath}");
        Console.WriteLine($"Размер файла: {_fileSize} байт");
        Console.WriteLine();
    }
}