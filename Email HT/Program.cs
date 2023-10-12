
//Email

//to - qabul qiladigan odam email addresi
//from - jo'natayogan odam email addresi
//subject - ushbu emaildan maqsad
//content - email mazmuni

//- email uchun Email modelidan foydalaning ( to, from, subject, content ) 
//-unda to va from set qilinganda valid email ekanligini tekshiring, valid bo'lmasa - FormatException
//- subject va content set qliinganda text valid ekanligini tekshiring, valid bo'lmasa - FormatException
//- Email modelini ToString ni chaqirganda email ma'lumotlarnini chiroyli stringga o'giradigan qiling
//- Email modelidan valid to, from, subject, content bilan bitta object yarating, ekranga chiqaring
//- Email modelidan invalid to, from, subject, content bilan bitta object yarating, ekranga chiqaring


using System.Text.RegularExpressions;


var email = new Email();
email.TO = "muhiddinov94@gmail.com";
email.FROM = "mominov456@mail.ru";
email.SUBJECT = "jahondfsdfd";
email.CONTENT = "avazbekoxun";

Console.WriteLine($"IT is the valids: \n{email}");





public class Email
{
    public string _to;
    public string _from;
    public string _subject;
    public string _content;


    public string TO
    {
        get => _to;
        set
        {
            string patern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(patern);

            if (regex.IsMatch(value))
            {
                _to = value;
            }
            else
            {
                throw new FormatException("your email is invalid");
            }
        }
    }
    public string FROM
    {
        get => _from;
        set
        {
            string patern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(patern);

            if (regex.IsMatch(value))
            {
                _from = value;
            }
            else
            {
                throw new FormatException("your email is invalid");
            }

        }
    }
    public string SUBJECT
    {
        get => _subject;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new FormatException("not empty");
            }
            _subject = value;
        }
    }
    public string CONTENT
    {
        get => _content;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new FormatException("not empty");
            }


            _content = value;
        }
    }
    public override string ToString()
    {
        return $"TO: {_to}\nFROM: {_from}\nSUBJECT: {_subject}\nCONTENT: {_content}\n";
    }

}

