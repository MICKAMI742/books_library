using System;
using System.Runtime.CompilerServices;

public class Book
{
    private string ID;
    private string title;
    private string author;
    private string genre;
    public bool isBorrowed;

    public Book(string title, string author, string genre, bool isBorrowed = false)
	{
        this.ID = Guid.NewGuid().ToString();
        this.title = title;
        this.author = author;
        this.genre = genre;
        this.isBorrowed = isBorrowed;
    }

    void BorrowBook()
    {
        if (isBorrowed)
        {
            Console.WriteLine("Book is already borrowed");
        }
        else
        {
            isBorrowed = true;
        }
    }

    void ReturnBook()
    {   
        if (!isBorrowed)
        {
            Console.WriteLine("Book is not borrowed");
        }
        else
        {
            isBorrowed = false;
        }
    }

    public string ShowBookInfo()
    {
        return ID + " " + title + " " + author + " " + genre + " " + isBorrowed;
    }
}
