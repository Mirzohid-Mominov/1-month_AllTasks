using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

var user = new USER()
{
    Name = "John",
    Surname = "Doe",
    Lastname = "Johnson"
};

var user2 = new USER()
{
    Name = "John",
    Surname = "Doe",
    Lastname = "Johnson"
};

user.Equals(user2);

//Console.WriteLine($"{user.Name} {user.Surname} {user.Lastname}");

//user.Name = "Toshmat";
Console.WriteLine(user2);

public class USER
{
    public string _name;
    public string _surname;
    public string _lastname;

    public string Name { 
        get => _name;
        set
        {
            _name = value;
            calculateFulname();
        }

    }
    public string Surname
    {
        get => _surname;
        set
        {
            _surname = value;
            calculateFulname();
        }
    }
    public string Lastname { get => _lastname; 
        set
        {
            _lastname = value;
            calculateFulname();
        }

    }

    public string _fullname;

    public void calculateFulname()
    {
        _fullname = $"{Name} {Surname} {Lastname}";
    }
    public string Fullname
    {
        get => _fullname;

    }

    public override bool Equals(object? obj)
    {
        if(obj is USER user)
        {
            return obj.GetHashCode() == user.GetHashCode() ? true : false;

        }
        return false;

    }

    public override int GetHashCode()
    {
        return this.Name.GetHashCode() + this.Surname.GetHashCode() + this._lastname.GetHashCode();
    }
}




