string[] formatFilms = new string[] {"Inception",
    "Dark Knight",
    "Top Gun 2",
    "Don't Look Up",
    "Top Gun" };

Console.Write("example: ");
foreach (string format in formatFilms)
{
    Console.WriteLine(format);
}


for (int i = 0; i < formatFilms.Length; i++)
{
    for(int j = 0; j < formatFilms.Length; j++)
    {
        if (formatFilms[i].CompareTo(formatFilms[j]) == 1)
        {
            var temp = formatFilms[i];
            formatFilms[i] = formatFilms[j];
            formatFilms[j] = temp;

        }
    }
}

Console.WriteLine(" ");
Console.Write("usish tartibida: ");

foreach (string format in formatFilms)
{
    Console.WriteLine(format);
}

public class FILMS
{
    public string name;

}