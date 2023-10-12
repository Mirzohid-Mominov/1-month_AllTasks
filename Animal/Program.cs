    //animal uchun Animal modelidan foydalaning unda FunFact methodi bo'lsin
//- FunFact methodi parametersiz shunchaki qiziqarli faktni ekranga chiqarsin
//- Animal dan 3 ta hayvon turi uchun tip yarating
//- ularda FunFact methodini e'lon qliing
//- 3 ta tipdan object e'lon qiling va 3 alasini ham Animal tipidagi o'zgaruvchida saqlang
//- 3 ta objectdan FunFact methodini chaqiring


ANIMAL animal = new horse();
ANIMAL animal1 = new Gepart();
ANIMAL animal2 = new Cat();

animal.FunFact();


public class ANIMAL
{
    public virtual void FunFact()
    {
        Console.WriteLine("The funfacts about 3 animals: ");
    }


}

public class horse : ANIMAL
{
    public override void FunFact()
    {
        Console.WriteLine("This animal never touch your foot");
    }

}

public class Gepart : ANIMAL
{
    public override void FunFact()
    {
        Console.WriteLine("The fastest animal of the animals is the Gepart in the world  ");
    }
}

public class Cat : ANIMAL
{
    public override void FunFact()
    {
        Console.WriteLine("as an example this animal has the great habit\nAlways it can pass down with foot to the earth");
    }
}
