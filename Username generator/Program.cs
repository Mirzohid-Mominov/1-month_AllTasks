//var substringnum = "fIRDaVs";
//var capitalized = string.Concat(substringnum.Substring(0, 1)
//    .ToUpper(), substringnum.Substring(1, 3).ToLower());

//Console.WriteLine(capitalized);


//Console.WriteLine("Enter your first name: ");
//var input = Console.ReadLine();

//var formatted = string.Concat(input.Substring(0, 1)
//    .ToUpper(), input.Substring(1).ToLower());

//Console.WriteLine(input.Equals(formatted));


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;


Console.WriteLine("Iltimos ism sharifingizni kiriting:");
var fullName = Console.ReadLine();

string[] usernames = { "mirzohidmominov", "umaralieshmurodov", "azamamonov", "azizbekabdurahmonov", "sultonbekrahimov", "shakhzodturakulov" };

var username = string.Empty;

for (var i = 0; i < fullName.Length; i++)
{
    if (fullName[i] != ' ')
    {
        username += fullName[i].ToString().ToLower();
    }
}


var rd = new Random();
if (usernames.Contains(username))
{
    username += rd.Next(1, 100);
}

Console.WriteLine($"Your username is: {username}");