using System.Runtime.CompilerServices;

var b1 = new BOOK
{
    Title = "Qalb iffati",
    Author = "Nuriya Chelen",
    id = Guid.NewGuid()
};

var b2 = new BOOK
{
    Title = "Ibodati Islomiya",
    Author = "Ahmad Hodiy Maqsudiy",
    id = Guid.NewGuid()
};

var b3 = new BOOK
{
    Title = "Quron Qalblar shifosi",
    Author = "Ziyovuddin Rahim",
    id = Guid.NewGuid()
};

var b4 = new BOOK
{
    Title = "Halqa",
    Author = "Akrom Malik",
    id = Guid.NewGuid()
};

var b5 = new BOOK
{
    Title = "Rich dad Poor dad",
    Author = "Robert Kiyosaki va Sharon L Lekter",
    id = Guid.NewGuid()
};

var b6 = new BOOK
{
    Title = "Halol luqma",
    Author = "Rauf Jilasun",
    id = Guid.NewGuid()
};

var b7 = new BOOK
{
    Title = "Choli qushi",
    Author = "Rashod Nuri Guntekin",
    id = Guid.NewGuid()
};

var b8 = new BOOK
{
    Title = "Raqamli qal'a",
    Author = "Dan Brownning",
    id = Guid.NewGuid()
};




var Books = new Librarymanagement();
Books.Books.Add(b1, 0);
Books.Books.Add(b2, 32);
Books.Books.Add(b3, 54);
Books.Books.Add(b4, 15);
Books.Books.Add(b5, 75);
Books.Books.Add(b6, 36);
Books.Books.Add(b7, 97);
Books.Books.Add(b8, 24);

Console.WriteLine(Books.CheckOut(b1.id));
public class BOOK
{

    public Guid id;
    public string Title;
    public string Author;
}

public class Librarymanagement
{
    public Dictionary<BOOK, int> Books = new Dictionary<BOOK, int>();
    public bool CheckOut(Guid Id)
    {
        foreach (var book in Books.Keys)
        {
            if (book.id == Id && Books[book] > 0)
            {
                Books[book]--;
                return true;
            }
        }

        return false;
    }


}





