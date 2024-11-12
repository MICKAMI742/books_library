public class User
{
    private string ID;
    private string name;
    private string surname;
    public string email { get; private set; }
    public string password { get; private set; }
    private List<Book> BorrowedBooks;
    public bool isAdmin;
    public bool isLogged;

    // constructor
    public User(string name, string email, string surname, string password)
    {
        this.ID = Guid.NewGuid().ToString();
        this.name = name;
        this.email = email;
        this.surname = surname;
        this.password = password;
        this.BorrowedBooks = new List<Book>();
        this.isAdmin = false;
        this.isLogged = false;
    }

    public string ShowUserInfo()
    {
        return ID + " " + name + " " + surname + " " + email;
    }

    private void ShowBorrowedBooks()
    {

    }

    private void BorrowBook()
    {

    }

    void ReturnBook()
    {

    }

    public void UserPanel(bool isLogged)
    {
        Console.WriteLine($"Welcome {this.name}\n" +
            "You need to click expected button to follow the function:\n" +
            "\tESC - log out\n" +
            "\t1 - show borrowed books\n" +
            "\t2 - borrow book\n" +
            "\t3 - return book"
            );
        ConsoleKey key = Console.ReadKey().Key;
        Console.Clear();
        while (isLogged)
        {
            switch (key)
            {
                case ConsoleKey.Escape:
                    Console.WriteLine("Logging out...");
                    System.Threading.Thread.Sleep(3000);
                    isLogged = false;
                    break;
                case ConsoleKey.D1:
                    ShowBorrowedBooks();
                    break;
                case ConsoleKey.D2:
                    BorrowBook();
                    break;
                case ConsoleKey.D3:
                    ReturnBook();
                    break;
                default:
                    Console.WriteLine("You clicked wrong button");
                    break;
            }
        }
    }

    public void AdminPanel(bool isLogged)
    {
        Console.WriteLine("Welcome to admin panel :)");   
    }
}
