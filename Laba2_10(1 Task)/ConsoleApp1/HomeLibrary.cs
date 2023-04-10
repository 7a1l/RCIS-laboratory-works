namespace Laba2_10;

public class HomeLibrary
{
    
    public string Name { get; }
    public int DateOfCreation { get; }
    public string AuthorName { get; }
    public int NumberOfPages { get; }
    public HomeLibrary()
    {
        this.Name = "";
        this.AuthorName = "";
    }
    public HomeLibrary(string AuthorName, int NumberOfPages, int DateOfCreation, string Name)
    {
        this.Name = Name;
        this.AuthorName = AuthorName;
        this.DateOfCreation = DateOfCreation;
        this.NumberOfPages = NumberOfPages;
    }

    public void Info()
    {
        Console.WriteLine($"name - {this.Name} Date of creation - {this.DateOfCreation} Number of pages - {this.NumberOfPages} Author name - {this.AuthorName}\n");
    }
}