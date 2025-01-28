class Program
{
    static void Main() //string[] args
    {
        File defaultFile = new();
        Console.WriteLine("Информация о defaultFile:");
        defaultFile.DisplayInfo();

        File parameterFile = new("example.txt", "C:\\example\\example.txt", 1024);
        Console.WriteLine("Информация о parameterFile:");
        parameterFile.DisplayInfo();

        parameterFile.FileName = ""; // Некорректное значение
        parameterFile.FullPath = ""; // Некорректное значение
        parameterFile.FileSize = -10; // Некорректное значение

        parameterFile.FileName = "new_example.txt"; // Корректное значение
        parameterFile.FullPath = "C:\\example\\new_example.txt"; // Корректное значение
        parameterFile.FileSize = 2048; // Корректное значение

        Console.WriteLine("Обновленная информация о файле:");
        parameterFile.DisplayInfo();

        File[] files = new File[]
        {
            new File("example.txt", "C:\\example\\example.txt", 1024),
            new File("image.png", "C:\\images\\image.png", 512),
            new File("summary.txt", "C:\\documents\\reports.txt", 256),
            new File("notes.txt", "C:\\notes\\lists.txt", 128)
        };

        string searchFileName = "example.txt";
        long searchFileSize = 500;

        Console.WriteLine("Файлы с указанным названием:");
        foreach (var file in files)
        {
            if (file.FileName == searchFileName)
            {
                file.DisplayInfo();
            }
        }

        Console.WriteLine($"Файлы, размер которых превышает {searchFileSize} байт:");
        foreach (var file in files)
        {
            if (file.FileSize > searchFileSize)
            {
                file.DisplayInfo();
            }
        }

    }
}

