using System.Diagnostics;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
Console.WriteLine("Bizni marketimizga xush kelibsz");
int[] prices = new.;

IEnumerable<int> distinctPrice = prices.Distinct();
Console.WriteLine("Distinct prices");

foreach (int price in distinctPrice)
{
    Console.WriteLine(price);
}

int count = 0;
int sum = 0;

foreach (int price in distinctPrice)
{
    for (int i = 0; i < prices.Count(); i++)
    {
        if (prices[i] == price) count++;
    }
    sum += (count - count / 3) * price;
}

Console.WriteLine(sum);
stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
Console.WriteLine(ts);




