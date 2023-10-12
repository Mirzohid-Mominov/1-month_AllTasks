var names = new List<string>();
names.Add("G'ayrat");
names.Add("Teshavoy");
names.Add("Boltavoy");
names.Add("Eshmat");

Dictionary<DateTime, int> uchishTime = new();

uchishTime.Add(new DateTime(2023, 8, 24, 09, 45, 15), 2);
uchishTime.Add(new DateTime(2019, 11, 16, 03, 21, 40), 4);
uchishTime.Add(new DateTime(2025, 07, 01, 15, 23, 23), 8);


const string companyName = "{{The Travel Guru}}";
const string nameToken = "{{Name}}";
const string companyNameToken = "{{CompanyName}}";
const string ticketDateToken = "{{ticetDate}}";

Dictionary<string, string> Messages = new Dictionary<string, string>()
{
    {"UnderAge", "Uzur hurmatli {{Name}} siz loyihadan forydalanish uchun kichkinasz!" },
    {"GoldenAge", "Uzur hurmatli{{Name}} Loyiha yoshlar uchun moljallangan! " }
};

LinkedList<string> Emails = new LinkedList<string>();
Emails.AddFirst("Hello {{Name}}. Welcome to onboard. {{CompanyName}} team");
Emails.AddLast("Your data is being processed and we will inform updates for you as soon as possible. {{CompanyName}} Team");
Emails.AddFirst("Congratulations! Your flight ticket is booked for {{TicketDate}}. {{CompanyName}} Team.");


int count = 0;

while(true)
{
    Console.WriteLine("Iltimos ismingizni kiriting: ");
    string Name = Console.ReadLine();


    if (string.IsNullOrEmpty(Name) || string.IsNullOrWhiteSpace(Name))
    {
        Console.WriteLine("Siz hech nima kiritmadingiz!\n Iltimos qaytadan kiriting\n");
    }
    else
    {
        int temp = 0;
        for (int i= 0 ; i < Name.Length ; i++)
        {
            if (Name[i] >= '0' && Name[i] < '9')
            {
                Console.WriteLine("invalid name\nIltimos qaytadan kiriting\n");
                temp = 1;
                break;
            }
        }
        if (temp == 0)
        {
            break;
        }
    }

    Console.WriteLine("Iltimos yoshingizni kiriting: ");
    int Age = int.Parse(Console.ReadLine());


    if (Age < 18)
    {
        Console.WriteLine(Messages[" UnderAge"].Replace(nameToken, Name));
    }
    else if (Age > 18 && Age < 90)
    {
        Console.WriteLine(Messages[" GoldenAge"].Replace(nameToken, Name));
    }
    else
    {

    }
    int traveller = 0;
    

};





//string txt = "Hello World What's happening in the World speak smth to me! ";
//string surName = "Mominov";
//string UserName = $"Ismi {txt} familiysi {surName} User";
//Console.WriteLine(surName[2]);

//int chaPos = txt.IndexOf("happening");

//Console.WriteLine(txt.Substring(chaPos));


//int myAge = int.Parse(Console.ReadLine());
////int myage = Convert.ToInt32(Console.ReadLine());

//int VotingAge = 18;
//if (myAge >= VotingAge)
//{
//    Console.WriteLine("your age is enough to vote!");
//}
//else
//{
//    Console.WriteLine("your age is not enough to vote!");
//}


//string[] cars = { "Ford", "BMW", "Mustang", "Mazda" };
//foreach(string i in cars)
//{
//    Console.WriteLine(i);
//}






