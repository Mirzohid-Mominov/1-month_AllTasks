using Lesson;

List<Student> student = new List<Student>()
{
    new Student(){ Id = 1, FullName = "Abdulxayev Jasurbek Anvar O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 2, FullName = "Abdumannonov Botirjon Davlat O'g'li",  BirthDay = new DateTime(2004, 1, 17),  EduType = "Python", Payment = 1600000, PaymentAmount = 500000 },
    new Student(){ Id = 3, FullName = "Abdurahmonov Azizbek Alisher O'g'li",  BirthDay = new DateTime(2003, 12, 12),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 3000000 },
    new Student(){ Id = 4, FullName = "Anvarjonov Ozodbek Avazxon O'g'li",  BirthDay = new DateTime(2003, 11, 1),  EduType = "SMM", Payment = 1450000, PaymentAmount = 2500000 },
    new Student(){ Id = 5, FullName = "Asadov Firdavs Asqarbek O'g'li",  BirthDay = new DateTime(2006, 7, 18),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 0 },
    new Student(){ Id = 6, FullName = "Eshmurodov Umarali Abduhalim O'g'li",  BirthDay = new DateTime(2005, 12, 12),  EduType = "SMM", Payment = 1450000, PaymentAmount = 900000 },
    new Student(){ Id = 7, FullName = "Jo'raboyev Boburjon Murodjon O'g'li",  BirthDay = new DateTime(2007, 4, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 8, FullName = "Karimjonov Ilhom Ramzjon O'g'li",  BirthDay = new DateTime(2005, 8, 1),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2500000 },
    new Student(){ Id = 9, FullName = "Komiljonov Muhammadaziz Abduraximovich",  BirthDay = new DateTime(2002, 1, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1500000 },
    new Student(){ Id = 10, FullName = "Rashidov Asadbek",  BirthDay = new DateTime(2001, 3, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 1900000 },
    new Student(){ Id = 11, FullName = "Sadriddinov Abdurahmon Jurabek O'g'li",  BirthDay = new DateTime(2003, 5, 12),  EduType = "Python", Payment = 1600000, PaymentAmount = 1700000 },
    new Student(){ Id = 12, FullName = "Sattorova Habiba Shuxrat Qizi",  BirthDay = new DateTime(2006, 2, 7),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2000000 },
    new Student(){ Id = 14, FullName = "Tolibov Firdavs Odil O'g'li",  BirthDay = new DateTime(2003, 5, 6),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2700000 },
    new Student(){ Id = 15, FullName = "To'rayev Dinur Alisher O'g'li",  BirthDay = new DateTime(2002, 8, 22),  EduType = "Python", Payment = 1600000, PaymentAmount = 2000000 },
    new Student(){ Id = 16, FullName = "Vositov Muhammadrizo Muhammadtolib O'g'li",  BirthDay = new DateTime(2000, 11, 20),  EduType = "SMM", Payment = 1450000, PaymentAmount = 1400000 },
    new Student(){ Id = 17, FullName = "Xaybullayev Mexroj Mansurjonovich",  BirthDay = new DateTime(2005, 2, 12),  EduType = "Dizayn", Payment = 1900000, PaymentAmount = 2000000 },
    new Student(){ Id = 18, FullName = "Xolmuratov Qurbonali Suxrob O'g'li",  BirthDay = new DateTime(2006, 5, 9),  EduType = "DotNET", Payment = 2400000, PaymentAmount = 2400000 },
};




Console.WriteLine("Dotnet talabalari");

Console.WriteLine("Talabalar ro'yxati ");
Console.WriteLine("1 dan 4 gacha raqam kiriting ");
Console.WriteLine("1 : Id va Fullname");
Console.WriteLine("2 tolovlar");
Console.WriteLine("3 Student qoshish: ");
Console.WriteLine("4 talaba uchirish: ");


int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        {
            Console.WriteLine("1 - Dotnet");
            Console.WriteLine("Choose your symbol ('X' or 'O'):");
            char symbol = char.ToUpper(Console.ReadKey().KeyChar);
            foreach (var item in student)
            {
                if (item.EduType == "DotNET")
                {
                    Console.WriteLine($"{item.Id} - {item.FullName}");
                }
            }
        }
        break;
    case 2:
        {
            Console.WriteLine("tolovlar");
            var tanlash = Console.ReadLine();

            foreach (var item in student)
            {
                if ((item.Payment - item.PaymentAmount) < 0)
                {
                    Console.WriteLine(item.FullName.PadRight(46, ' ') + "\t" + item.Payment + "  Umumiy tolashi kerak bolgan puli ".PadRight(40, ' ') + item.GetAmount().PadRight(30, ' '));
                }
            }
        }
        break;
    case 3:
        {
            foreach(var item in student)
            {
                Console.WriteLine($"{item.Id} {item.FullName.PadRight(45, ' ')}");

            }
            Console.Write("FIO");
            string FIO = Console.ReadLine();

            Console.Write("Yunalish: ");
            string EduType = Console.ReadLine();

            student.Add(new Student
            {
                Id = student.Last().Id + 1,
                FullName = FIO,
                BirthDay = DateTime.Now,
                EduType = EduType
            });
            
            foreach (var item in student)
            {
                Console.WriteLine($"{item.Id} {item.FullName.PadRight(45, ' ')}");
            }
        }
        break;
    case 4:
    {
        foreach (var item in student)
        {
            Console.WriteLine($"{item.Id} {item.FullName.PadRight(45, ' ')}");

        }
        
        Console.Write("uchirmoqchi bolgan talabani Id sini kiriting: ");
        int raqam = Int32.Parse(Console.ReadLine());
        
        student.RemoveAt(raqam - 1);
        
            foreach (var item in student)
            {
                Console.WriteLine($"{item.Id} {item.FullName.PadRight(45, ' ')}");
            }
        }
        break;

}
















//Console.WriteLine(Guid.NewGuid().ToString());








/*
Console.WriteLine("DotNet talabalari: ");
foreach (var item in student)

{
    if (item.EduType == "DotNET")
        Console.WriteLine($"{item.Id} - {item.FullName}");
}




Console.WriteLine("Talabalar ro'yxati ");
Console.WriteLine("1 dan 4 gacha raqam kiriting ");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

switch(a)
    { 
        case 1:
        {
            Console.WriteLine("1 - Dotnet");
            Console.WriteLine("Choose your symbol ('X' or 'O'):");
            char symbol = char.ToUpper(Console.ReadKey().KeyChar);
            foreach (var item in student)
            {
                if (item.EduType == "DotNET")
                {
                    Console.WriteLine($"{item.Id} - {item.FullName}");
                }
            }
        }
            break;

        case 2:
        {
            Console.WriteLine("2 - SMM");
            Console.WriteLine("Choose your symbol ('X' or 'O'):");
            char symbol = char.ToUpper(Console.ReadKey().KeyChar);
            foreach (var item in student)
            {
                if (item.EduType == "SMM")
                {
                    Console.WriteLine($"{item.Id} - {item.FullName}");
                }
            }
        }
            break;
        case 3:
            {
                Console.WriteLine("3 - Python");
                Console.WriteLine("Choose your symbol ('X' or 'O'):");
                char symbol = char.ToUpper(Console.ReadKey().KeyChar);
                foreach (var item in student)
                {
                    if (item.EduType == "Python")
                    {
                        Console.WriteLine($"{item.Id} - {item.FullName}");
                    }
                }
            }
            break;
        case 4:
            {
                Console.WriteLine("4 - Dizayn");
                Console.WriteLine("Choose your symbol ('X' or 'O'):");
                char symbol = char.ToUpper(Console.ReadKey().KeyChar);
                foreach (var item in student)
                {
                    if (item.EduType == "Dizayn")
                    {
                        Console.WriteLine($"{item.Id} - {item.FullName}");
                    }
                }
            }
            break;
        case 5:
            {
                int[,] balls = new int[,]
            {
                { 90, 100, 75, 60 },
                { 100, 100, 70, 0 },
                { 90, 50, 60, 100 },
                { 60, 50, 100, 90 },
                { 100, 10, 75, 45 },
                { 55, 85, 70, 60 },
                { 95, 90, 40, 100 },
                { 80, 100, 100, 40 },
                { 65, 80, 100, 50 },
                { 80, 90, 100, 60 },
                { 90, 85, 65, 55 },
                { 100, 55, 90, 100 },
                { 80, 75, 90, 60 },
                { 90, 90, 100, 55 },
                { 100, 60, 90, 75 },
                { 90, 80, 50, 100 },
                { 100, 100, 60, 60 },
                { 90, 50, 80, 90 },
            };
            var date = DateTime.Now;
            Console.WriteLine(date);

            for(int i = 0;  i < balls.Length;  i++)
            {
                Console.Write($"{student[i].FullName} ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("\t" + balls[i, j]);
                }
                Console.WriteLine();
            }
        }
        break;


}



"""

Console.WriteLine("Choose your symbol ('X' or 'O'):");
char symbol = char.ToUpper(Console.ReadKey().KeyChar);
"""
*/



