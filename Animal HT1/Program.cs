using System.ComponentModel.DataAnnotations;

//hayvonlar uchun Animal modelidan foydalaning
//- Animal modelidan MakeSound methodi bo'lsin - shunchaki ekranga "..." chiqsin
//- undan Bird, Mammal, Fish voris modellarini yarating
//- Bird modelida Fly methodi bo'lsin - shunchaki ekranga "Fly" deb chiqarsin
//- Mammal modelida Run methodi bo'lsin - shunchaki ekranga "Run" deb chiqarsin
//- Fish modelida Swim methodi bo'lsin - shunchaki ekranga "Swim" deb chiqarsin
//- Bird modelidan Sparrow voris modelini yarating
//- Mammal modelidan Tiger voris modelini yarating
//- Fish modelidan Great White Shark voris modelini yarating
//- vorislik ierarxiyasidagi eng pastdagi modellardan object yarating va o'zlaridagi unique bo'lgan methodlarni ekrangaa chiqaring


//using System.Threading.Channels;

//public class Animal
//{
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("...");
//    }
//}

//public class Bird : Animal
//{
//    public override void MakeSound() 
//    {
//        Console.WriteLine("Fly");
//    }
//}

//public class Mammal : Animal
//{
//    public override void Run()
//    {

//    }
//}



//class Person
//{
//    public string name;
//    public int age;

//    Person() { name = "Nomalum"; age = 10; }
//    Person(string n) { name = n; age = 18; }

//    public void getInfo()
//    {
//        Console.WriteLine($"Name: {name} Age: {age}");
//    }
//}






public class Person
{
    public string name;
    public int age;

    public Person() { name = "nomalum"; age = 19; }
    public Person() { name = "hello"; age = 19; }

    }
}