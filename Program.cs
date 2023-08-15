using BaiTapCSharp.demo1;

class Program
{
    static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();

        phoneBook.InsertPhone("Dũng", "123-456-7890");
        phoneBook.InsertPhone("Long", "987-654-3210");
        phoneBook.InsertPhone("Minh", "555-123-4567");

        phoneBook.UpdatePhone("Dũng", "999-888-7777"); 

        phoneBook.SearchPhone("Dũng");
        phoneBook.SearchPhone("Long");
        phoneBook.SearchPhone("My"); 

        phoneBook.Sort();

        phoneBook.RemovePhone("Minh");
    }
}
