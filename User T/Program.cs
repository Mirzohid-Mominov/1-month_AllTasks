//Foydalanvuchi dasturi

//- foydalanuvchi uchun User tipini yarating
//- unda FirstName, LastName, Age fieldlarni bo'lsin
//- foydalanuvchidan ismi, sharifi, yoshini kiritishni so'rang
//- kiritilgan qiymatlar bilan User tipidan user nomli yangi object yarating
//- user o'zgaruvchisidagi fieldlarni ekranga chiqaring

using System.Threading.Channels;

var firstName = default(string);
var lastName = default(string);
var age = default(int);

Console.WriteLine("Enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Enter your last name: ");
lastName = Console.ReadLine();

Console.WriteLine("Enter your age: ");
age = int.Parse(Console.ReadLine());

var user = new User
{
    FirstName = firstName,
    LastName = lastName,
    Age = age
};


Console.WriteLine($"Firstname: {user.FirstName}");
Console.WriteLine($"Lastname:  {user.LastName}");
Console.WriteLine($"Age:       {user.Age}");
public class User
{
    public string FirstName;
    public string LastName;
    public int Age;

}
