using System.Net.Mail;
using System.Text.RegularExpressions;


string email;
Console.WriteLine("Email checcer!\n\n");
do
{
    Console.WriteLine("Iltimos email ni kiriting: ");
    email = Console.ReadLine();
}
while (string.IsNullOrWhiteSpace(email));

var emailAddresRejax = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");
var emailAddresPatttern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
if(!Regex.IsMatch(email, emailAddresPatttern))
{
    Console.WriteLine("Siz Kiritgan email notori: ");
}
else
{
    Console.WriteLine(email + "\nGood");
}






//Console.WriteLine(Regex.IsMatch(emailAddress, emailAddressPattern));
//Console.WriteLine(emailAddressRegex.IsMatch(emailAddress));


//Console.Write("Enter you email address : ");
//var emailAddress = Console.ReadLine();
//var emailAddressRegex = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");
//var emailAddressPattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";















