namespace BookLibrary
{
    class Book
    {
        public string Title;
        public string Genre;
        public int Year;
        public string Author;
        public bool IsCompleted = false;
        public Game(string genre, string title, int year, string author, bool iscompleted)
        {
            Title = title;
            Genre = genre;
            Year = year;
            Author = author;
            IsCompleted = iscompleted;
        }
        public void ShowInfo()
        {
            if (IsCompleted == false)
            {
                System.Console.WriteLine($"Книга {Title}, Жанр: {Genre}, Год{Year}, Автор {Platform}, Статус : не прочитана.");
            }
            else
            {
                System.Console.WriteLine($"Книга {Title}, Жанр: {Genre}, Год{Year}, Автор {Platform}, Статус: прочитана.");
            }
        }
        public void MarkAsCompleted()
        {
            IsCompleted = true;
            System.Console.WriteLine($"✓ Книга {Title} отмечена как прочитана");
        }
    }
}