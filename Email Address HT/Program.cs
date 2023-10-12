//Email addresslarni yaroqli ekanligini tasdiqlovchi dastur tuzing

//- 5 ta email addressni kolleksiyada saqlang
//- ularni regex bilan tekshirib, yaroqli yoki yaroqli emas ekanligini chiqaring

//Example

//- t.com - Invalid



using System.Text.RegularExpressions;

List<string> emails = new List<string>();
emails.Add("Mirzohid.com");
emails.Add("Mirzohid@gmail.com");
emails.Add("Mirzohid@com");
emails.Add("Mirzohid@gmail");
emails.Add("Mirzohid.com@gmail");

var emailRegex = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");

for (int i = 0; i < emails.Count; i++)
{
    Console.WriteLine(emailRegex.IsMatch(emails[i]));
}
