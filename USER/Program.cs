using System.Net.Mail;

var userName = new List<USER>();
userName.Add(new USER { name = "Peter", secondName = "Michael", lastName = "Brown" });
userName.Add(new USER { name = "John", secondName = "David", lastName = "Smith" });
userName.Add(new USER { name = "Mary", secondName = "Anne", lastName = "Jones" });
userName.Add(new USER { name = "ishtmat", secondName = "G`ishtmatov", lastName = "Brown" });
userName.Add(new USER { name = "Peter", secondName = "Michael", lastName = "G`ishtmatovich" });


Console.WriteLine("Ismingizni kiriting: ");
var name1 = Console.ReadLine();
Console.WriteLine("familiyangizni kiriting: ");
var secondName1 = Console.ReadLine();
Console.WriteLine("Sharifingizni kiriting: ");
var lastName1 = Console.ReadLine();

var allUser = new USER { name = name1, secondName = secondName1, lastName = lastName1 };

for(int i = 0; i < userName.Count; i++)
{
    if (allUser.Equals(userName[i]))
    {
        Console.WriteLine("NAvbatda borsiz");
        break;
    }
    else
    {
        userName.Add(allUser);
    }
}

for(int i = 0; i < userName.Count; i++)

{
    Console.WriteLine(userName[i]);
}

public class USER
{
    public string name;
    public string secondName;
    public string lastName;

    //public string fullname => $"{name} {secondName} {lastName}";

    public override bool Equals(object? obj)
    {
        if(obj is USER userName)
        {
            return obj.GetHashCode() == userName.GetHashCode() ? true : false;
        }
        return false;
    }
    

    public override int GetHashCode()
    {
        return this.name.GetHashCode() + this.secondName.GetHashCode() + this.lastName.GetHashCode();
    }

}
