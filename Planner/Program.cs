//plan qiladigan Planner service dan foydalaning
//- unda Add methodi bo'lsin - u kunlik eventlarni nomi bilan kolleksiyaga qo'shib borsin
//- Display - display methodi barcha eventlarni ekranga chiqarsin
//- object oling, 3 ta daily event qo'shing va display qiling 

//- barcha eventlarni plan qiladigan UltimatePlanner servise dan foydalaning
//- unda parentdagi Add methodi override qilinsin - bitta soat ga to'g'ri keladigan 2 ta event kiritilganda - "You have conflict in daily plan" yozuvi chiqsin
//- unda yangi Add methodi bo'lsin - u kalendar eventlarni kolleksiyaga qo'shsin
//- Display methodi override qiling va unda oldin kalendar va keyin kunlik eventlar ekranga chiqarilsin
//- object oling, 3 ta daily event ( 2 tasi bitta soatda ) qo'shing, 3 ta kalendar event qo'shing va display qiling




using System.Security.Cryptography.X509Certificates;

var events = new PLANNER();
events.EveryEvents.Add("Azizbek", new DateOnly(2023, 01, 12));
events.EveryEvents.Add("Azam", new DateOnly(2025, 10, 13));
events.EveryEvents.Add("Firdavs", new DateOnly(2018, 08, 16));
events.EveryEvents.Add("Abdurahmon", new DateOnly(2043, 06, 22));
events.EveryEvents.Add("Asadbek", new DateOnly(2016, 04, 29));
events.EveryEvents.Add("Javohir", new DateOnly(2028, 3, 30));


events.Display();






public class UltimatePlanner : PLANNER
{
    public Dictionary<string, TimeOnly> ExactEvents = new Dictionary<string, TimeOnly>();

    public override void ADD(string names, DateOnly date)
    {
        EveryEvents.Add(names, date);
        

    }
    public void ADD(string names, TimeOnly time)
    {
        var conflict = true;

        ExactEvents.Add(names, time);
        foreach (var item in ExactEvents)
        {
            if (item.Value.Hour == time.Hour)
            {
                Console.WriteLine("You have conflict in daily plan");
                break;
            }
        }
        if(conflict)
        {
            Console.WriteLine();
        }

    }

    public override void Display()
    {
        Console.WriteLine("Bitta soatga to'g'ri keladigan eventlar: ");
        foreach (var name in ExactEvents)
        {
            Console.WriteLine($"Event nomlari: {name.Key}\nEvent vaqtlari: {name.Value}");
        }
        Console.WriteLine();

    }
}


public class PLANNER
{


    public Dictionary<string, DateOnly> EveryEvents = new Dictionary<string, DateOnly>();

    public virtual void ADD(string names, DateOnly date)
    {
        EveryEvents.Add(names, date);

    }

    public virtual void Display()
    {
        Console.WriteLine("Kunlik barcha eventlar: ");
        foreach (var name in EveryEvents)
        {
            Console.Write($"Event egalari: {name.Key}\nEvent vaqtlari: {name.Value}");
        }
        Console.WriteLine();


    }
}









