

var objectValue = default(object);

try
{
    Console.WriteLine(objectValue.ToString());

    if (objectValue is null)
        throw new NullReferenceException($"{nameof(objectValue)} is null");
    Console.WriteLine("hi");
}

catch (NullReferenceException nulReferenceException)
{
    Console.WriteLine(nulReferenceException);
    Console.WriteLine("hello");
}
catch (Exception)
{
    Console.WriteLine("Ish tugadi");
}



//using System.Text.RegularExpressions;

//Console.Write("Enter your email address: ");
//var emailAddress = Console.ReadLine();

//var emailRegex = new Regex("^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$");

//Console.WriteLine(emailRegex.IsMatch(emailAddress));




//var emailRegexPattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$";
//Console.WriteLine(Regex.IsMatch(emailAddress, emailRegexPattern));

////ConsoleKeyInfo keyInfo = Console.ReadKey();
///

