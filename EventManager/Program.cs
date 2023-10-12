var eventmanager = new EventManager();
eventmanager.Add("Azizbek", new DateTime(2023, 01, 12));
eventmanager.Add("Azam", new DateTime(2025, 10, 13));
eventmanager.Add("Firdavs", new DateTime(2018, 08, 16));
eventmanager.Add("Abdurahmon", new DateTime(2043, 06, 22));
eventmanager.Add("Asadbek", new DateTime(2016, 04, 29));
eventmanager.Add("Javohir", new DateTime(2028, 3, 30));

eventmanager.Add("Ilhomjon", new TimeOnly(8, 34));
eventmanager.Add("Jalolxon", new TimeOnly(14, 45));
eventmanager.Add("Xurshid", new TimeOnly(22, 52));
eventmanager.Add("Abdulaziz", new TimeOnly(12, 25));
eventmanager.Add("Ozodbek", new TimeOnly(23, 21));
eventmanager.Add("Behruz", new TimeOnly(6, 23));
eventmanager.Add("Islombek", new TimeOnly(10, 12));

var all = new EventManager();
all.Display();


public class EventManager
{
    public Dictionary<string, DateTime> ExactEvents = new Dictionary<string, DateTime>();
    public Dictionary<string, TimeOnly> everyEvents = new Dictionary<string, TimeOnly>();

    public void Add(string name,  DateTime date)
    {
        ExactEvents.Add(name, date);
    }

    public void Add(string name, TimeOnly time)
    {
        everyEvents.Add(name, time);

    }

    public void Display()
    {
        Console.WriteLine("Har kungilik eventlar: ");
        foreach (var  name in ExactEvents)
        {
            Console.WriteLine($"{name.Key} {name.Value}");
        }

        Console.WriteLine("");
    }
}

