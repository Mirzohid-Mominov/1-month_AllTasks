var cars = new List<CAR>();
cars.Add(new CAR { name = "Epika", brand = "Chewrolet" });
cars.Add(new CAR { name = "BMW X6", brand = "BMW" });
cars.Add(new CAR { name = "land cruiser 300", brand = "TOYOTO" });
cars.Add(new CAR { name = "CAYMAN", brand = "PORCHE" });
cars.Add(new CAR { name = "escalade 2021", brand = "CADILAC" });
cars.Add(new CAR { name = "Epika", brand = "Chewrolet" });
cars.Add(new CAR { name = "Epika", brand = "Chewrolet" });
cars.Add(new CAR { name = "CAYMAN", brand = "PORCHE" });
cars.Add(new CAR { name = "BENTAYGA", brand = "BENTLEY" });
cars.Add(new CAR { name = "LAFERRARI", brand = "FERRARI" });
cars.Add(new CAR { name = "LAFERRARI", brand = "FERRARI" });
cars.Add(new CAR { name = "escalade 2021", brand = "CADILAC" });
cars.Add(new CAR { name = "BMW X6", brand = "BMW" });
cars.Add(new CAR { name = "CAYMAN", brand = "PORCHE" });
cars.Add(new CAR { name = "TIGGO 7 PRO", brand = "CHERY" });
cars.Add(new CAR { name = "TIGGO 7 PRO", brand = "CHERY" });
cars.Add(new CAR { name = "TIGGO 7 PRO", brand = "CHERY" });
cars.Add(new CAR { name = "BENTAYGA", brand = "BENTLEY" });


for (int i = 0; i < cars.Count; i++)
{
    int count = 0;

    for (int j = 0; j < cars.Count - 1; j++)
    {
        if (cars[i].GetHashCode() == cars[j].GetHashCode())
        {
            count += 1;
        }

    }
    if(count > 0)
    {
        Console.WriteLine(cars[i].name + " : " + count);
    }

}


public class CAR
{
    public string name;
    public string brand;

    public override bool Equals(object? obj)
    {
        if (obj is CAR cars)
        {
            return cars.GetHashCode() == obj.GetHashCode() ? true : false;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return this.name.GetHashCode() + this.brand.GetHashCode();
    }

}