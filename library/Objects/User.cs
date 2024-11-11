using System;
using System.ComponentModel.DataAnnotations;

public class User
{
    private string ID;
    private string name;
    private string surname;
    private string email;
    private string password;
    private List<Book> BorrowedBooks;
    private bool isAdmin;
    private bool isLogged;

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

    public void Login()
    {

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
}
