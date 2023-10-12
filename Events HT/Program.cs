
//Eventlar jadvali bo'lgan dasturni tuzing

//- 5 ta event nomi va bo'lib o'tish vaqti alohida saqlansin ( hammasini vaqti kelajakda, o'tib ketgan eventmas )
//- 3 ta har xil millat ( uz, ru, en ) alohida saqlansin
//- eventlarni o'sib borish tartibida saralang
//- 5 ta eventni va vaqtini har bir millat uchun chiqarish dasturini tuzing - bunda event nomini tarjima qilish kerakmas, faqat vaqti shunga most format qilinsa bo'ldi


using System.Collections;
using System.Reflection.Emit;

List<string> events = new List<string>();
events.Add("FrontSpot About new Angular features");
events.Add("AWS Tashkent - Develop your ML Project with Amazon SageMaker");
events.Add("GDG - Google IO Extended ");
events.Add("MDC - Sharpist hackathon ");
events.Add("WoW 2.0 - Let's talk about Caching ");

List<string> nationalities = new List<string>();
nationalities.Add("Eng");
nationalities.Add("Uzb");
nationalities.Add("Rus");

List<DateTime> dates = new List<DateTime>();
dates.Add(new DateTime(2023, 08, 10, 09, 00, 00));
dates.Add(new DateTime(2023, 08, 15, 11, 00, 00));
dates.Add(new DateTime(2023, 08, 20, 15, 00, 00));
dates.Add(new DateTime(2023, 09, 15, 09, 00, 00));
dates.Add(new DateTime(2023, 09, 23, 18, 00, 00));

dates.Sort();

for (int i = 0; i < events.Count; i++)
{
    //Console.WriteLine(nationalities);
    //events.Add(nationalities[i]);
    for (int j = 0; j < dates.Count; j++)
    {

        if (events[i] == events[j])
        {
            events[i] += Convert.ToString(dates[j] + "\n");
        }
    }
}

foreach(var allevents in events)
{
    Console.WriteLine("Uzb: " + allevents);
}

Console.WriteLine("");

foreach (var allevents in events)
{
    Console.WriteLine("Rus: " + allevents);
}
Console.WriteLine("");

foreach (var allevents in events)
{
    Console.WriteLine("Eng: " + allevents);
}


//Example 

////en
////-" FrontSpot About new Angular features - 08.10.2023 09:00 AM"
////- "AWS Tashkent - Develop your ML Project with Amazon SageMaker - 08.15.2023 11:00 AM"
////- "GDG - Google IO Extended - 20.08.2023 03:00 PM"
////- "MDC - Sharpist hackathon - "15.09.2023 09:00 AM"
////- "WoW 2.0 - Let's talk about Caching - 23.09.2023 06:00 PM"


//using System.Reflection;

//Dictionary<string, DateTime> EngEvents = new Dictionary<string, DateTime>();
//EngEvents.Add("FrontSpot About new Angular features - ", new DateTime(2023, 10, 08, 9, 00, 01));
//EngEvents.Add("AWS Tashkent - Develop your ML Project with Amazon SageMaker -", new DateTime(2023, 15, 08, 11, 00, 72));
//EngEvents.Add("GDG - Google IO Extended - ", new DateTime(2023, 08, 20, 15, 00, 28));
//EngEvents.Add("MDC - Sharpist hackathon - ", new DateTime(2023, 09, 15, 09, 00, 37));
//EngEvents.Add("WoW 2.0 - Let's talk about Caching - ", new DateTime(2023, 09, 23, 18, 00, 23));


////ru
////- "FrontSpot About new Angular features - 10/08/2023 09:00"
////- "AWS Tashkent - Develop your ML Project with Amazon SageMaker - 15/08/2023 11:00"
////- "GDG - Google IO Extended - 20/08/2023 15:00"
////- "MDC - Sharpist hackathon - "15/09/2023 09:00"
////- "WoW 2.0 - Let's talk about Caching - 23/09/2023 18:00"


//Dictionary<string, DateTime> RusEvents = new Dictionary<string, DateTime>();
//RusEvents.Add("FrontSpot About new Angular features - ", new DateTime(2023, 08, 10, 9, 00, 01));
//RusEvents.Add("AWS Tashkent - Develop your ML Project with Amazon SageMaker -", new DateTime(2023, 08, 15, 11, 00, 72));
//RusEvents.Add("GDG - Google IO Extended - ", new DateTime(2023, 09, 15, 09, 00, 28));
//RusEvents.Add("MDC - Sharpist hackathon - ", new DateTime(2023, 09, 23, 18, 00, 37));
//RusEvents.Add("WoW 2.0 - Let's talk about Caching - ", new DateTime(2023, 09, 23, 18, 00, 23));


////uz
////- "FrontSpot About new Angular features - 10.08.2023 09:00"
////- "AWS Tashkent - Develop your ML Project with Amazon SageMaker - 15.08.2023 11:00"
////- "GDG - Google IO Extended - 20.08.2023 15:00"
////- "MDC - Sharpist hackathon - "15.09.2023 09:00"
////- "WoW 2.0 - Let's talk about Caching - 23.09.2023 18:00"

//Dictionary<string, DateTime> UzbEvents = new Dictionary<string, DateTime>();
//UzbEvents.Add("FrontSpot About new Angular features - ", new DateTime(2023, 08, 10, 9, 00, 01));
//UzbEvents.Add("AWS Tashkent - Develop your ML Project with Amazon SageMaker -", new DateTime(2023, 08, 15, 11, 00, 72));
//UzbEvents.Add("GDG - Google IO Extended - ", new DateTime(2023, 08, 20, 15, 00, 28));
//UzbEvents.Add("MDC - Sharpist hackathon - ", new DateTime(2023, 09, 15, 09, 00, 37));
//UzbEvents.Add("WoW 2.0 - Let's talk about Caching - ", new DateTime(2023, 09, 23, 18, 00, 23));



//SortedDictionary<string, DateTime> sortedDict = new SortedDictionary<string, DateTime>(UzbEvents);

////Console.WriteLine(sortedDict);
//foreach(var events in EngEvents.OrderBy(e => e.Key))
//{
//    Console.WriteLine(events.Key + " : " + events.Value      

//        );
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Create an unsorted dictionary
//        Dictionary<string, int> unsortedDict = new Dictionary<string, int>
//        {
//            {"Apple", 10},
//            {"Orange", 5},
//            {"Banana", 15},
//            {"Grapes", 8}
//        };

//        // Sort and display the dictionary using LINQ
//        foreach (var kvp in unsortedDict.OrderBy(x => x.Key))
//        {
//            Console.WriteLine(kvp.Key + ": " + kvp.Value);
//        }
//    }
//}


//Dictionary<string, DateTime> appointments = new Dictionary<string, DateTime>();

//// Adding key-value pairs to the dictionary
//appointments.Add("Meeting with the team", new DateTime(2023, 10, 8, 9, 0, 0));
//appointments.Add("Project deadline", new DateTime(2023, 10, 10, 15, 30, 0));

