using System;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

//Console.WriteLine("Iltimos yoshingizni kiriting! ");
//int age  = int.Parse(Console.ReadLine());
//try
//{
//    var agelevel = age switch
//    {
//        < 18 => throw new ArgumentOutOfRangeException("Sorry you are too old!"),
//        > 90 => throw new ArgumentOutOfRangeException("Valid age!"),
//        _=>"Valid age"
//    };
//    Console.WriteLine(agelevel);
//}

//catch(ArgumentOutOfRangeException ex) {
//    Console.WriteLine(ex);
//}


//Random randomNumber = new Random();
//int rand = randomNumber.Next(1, 10);

//while (true)
//{
//    try
//    {
//        Console.WriteLine("Iltimos son kiriting!");
//        //Console.WriteLine(rand);
//        var number = Console.ReadLine();


//        if (int.TryParse(number, out int num))
//        {
//            if (num == rand)
//            {
//                Console.WriteLine("congrats!");
//                break;
//            }
//            else
//            {
//                throw new ArgumentOutOfRangeException("Teng emas:");
//            }
//        }
//        else
//        {
//            throw new FormatException("Not a number");
//        }
//    }
//    catch(FormatException ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//    catch(ArgumentOutOfRangeException arx)
//    {
//        Console.WriteLine(arx.Message);
//    }
//}



//string[] cars = { "Volvo", "BMW", "Ford", "Mazda"};
//cars[0] = "Opel";
//Console.WriteLine(cars.Length);

//string[] cars = new string[4];



//string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//foreach(string i in cars)
//{
//    Console.WriteLine(i);
//}


//string[] cars = { "Abc", "Mazda", "Ford" };
//Array.Sort(cars); ;
//foreach(string i in cars)
//{
//    Console.WriteLine(i);
//}

//int[] MyNumbers = { 5, 3, 5, 6, 2, 52, 5, 78, 2 };
//Array.Sort(MyNumbers);
//foreach(var i in MyNumbers)
//{
//    Console.Write(i + "\n");
// }

//int[] MyNUmbers = { 5, 3, 5, 6, 2, 52, 5, 78, 2 };
//Console.WriteLine(MyNUmbers.Max());
//Console.WriteLine(MyNUmbers.Min());
//Console.WriteLine(MyNUmbers.Sum());

int[,] numbers = { {1, 4, 6 }, 
                   {3, 6, 8 } };
////Console.WriteLine(numbers[0,2]);

//numbers[0, 0] = 5;
////Console.WriteLine(numbers[0,0]);
//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//for(int i = 0; i < numbers.GetLength(0); i++)
//{
//    for(int j = 0; j <  numbers.GetLength(1); j++)
//    {
//        Console.Write(numbers[i,j] + " ");
//    }
//    Console.WriteLine();
//}







//Console.WriteLine("Relational pattern matching : ");

//var grade = 80;
//var gradeLevel = grade switch
//{
//    >= 90 => "Top",
//    >= 80 and < 90 => "Good",
//    >= 70 and < 80 => "Normal",
//    _ => "Bad"
//};
//Console.WriteLine(gradeLevel);