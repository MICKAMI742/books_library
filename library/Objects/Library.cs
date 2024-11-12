public class Library
{
    static private List<Book> books = new List<Book>();
    static private List<User> users = new List<User>();

    public void CreateAccount()
    {
        string name = "";
        string surname = "";
        string email = "";
        string password = "";
        bool isEmpty = true;
        while (isEmpty)
        {

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter your email: ");
            email = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();
            if (name == "" || surname == "" || email == "" || password == "")
            {
                Console.WriteLine("Please fill all the fields");
            }
            else
            {
                isEmpty = false;
            }
        }
        User user = new User(name, email, surname, password);
        users.Add(user);
    }

    public void ShowUsers()
    {
        foreach (User user in users)
        {
            Console.WriteLine(user.ShowUserInfo());
        }
    }

    public void ShowBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book.ShowBookInfo());
        }
    }

    public void LogIn()
    {
        Console.WriteLine("Enter your email: ");
        string email = Console.ReadLine();
        foreach (User user in users)
        {
            if (user.email == email)
            {
                Console.WriteLine("Enter your password: ");
                string password = Console.ReadLine();
                if (user.password == password)
                {
                    user.isLogged = true;
                    if (!user.isAdmin)
                    {
                        Console.Clear();
                        user.UserPanel(user.isLogged);
                    }
                    user.AdminPanel(user.isLogged);
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Wrong email");
            }
        }
    }

    public void AddBook()
    {
        string title = "";
        string author = "";
        string genre = "";
        Console.WriteLine("Enter book title: ");
        title = Console.ReadLine();
        Console.WriteLine("Enter book author: ");
        author = Console.ReadLine();
        Console.WriteLine("Enter book genre: ");
        genre = Console.ReadLine();
        Console.WriteLine("Book added");

        Book book = new Book(title, author, genre);
        books.Add(book);
    }

    public void DeleteBook()
    {
        int position = 1;
        foreach (Book book in books)
        {
            Console.WriteLine(position + " " + book.ShowBookInfo());
            position++;
        }
        Console.WriteLine("Enter the number of book you want to delete: ");
        int bookNumber = Convert.ToInt32(Console.ReadLine());
        books.RemoveAt(bookNumber - 1);
        Console.WriteLine("Book deleted");
    }
}