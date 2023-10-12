using System.Runtime.ExceptionServices;

Console.WriteLine("Essay analizer: ");
int ball = 100;
var essay = "Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!";
string[] AllWords = essay.Split(' ');


for (int i = 0; i <= AllWords.Length - 1; i++)
{
    if (AllWords[i][AllWords[i].Length - 1] == '.')
    {
        char harf = AllWords[i + 1][0];

        if (char.IsLower(harf))
        {
            ball = ball - 5;
        }
    }
}
for (int i = 0; i < AllWords.Length - 1; i++)
{
    int num = 0;
    for (int j = i; j < AllWords.Length - 1; j++)
    {
        if (AllWords[i] == AllWords[j])
        {
            num += 1;
        }
    }
    if (num >= 100)
    {
        ball -= 5;
    }
}

if (AllWords.Length <= 500)
{
    ball -= 5;
}


for (int i = 0; i < AllWords.Length; i++)
{
    if (AllWords[i].Length >= 20)
    {
        ball -= 20;

    }
}

bool count = false;

string[] AllSentences = essay.Split('.', '?', '!');
foreach (var i in AllSentences)
{
    for(var j = 1;j < i.Length;j++)
    {
        if (i[j] >= 'A' && i[j] <='Z')
        {
            count = true; break;
        }

    }
}

if(count == true)
{
    ball -= 10;
}
Console.WriteLine(ball);

//foreach (int i in AllWords)
//{
//    char soz1 = AllWords[i];
//    if (char.IsLower(soz1))
//    {
//        Console.WriteLine(AllWords[i]);
//        ball -= 10;
//    }
//}

//foreach (var i in AllWords)
//{
//    char clone = i[0];

//    if (i.Length-1 == '.')
//    {


//    }

//foreach (var word2 in clone)
//{
//    char clone2 = word2[0];

//    if (char.IsLover(clone2))
//    {
//        words -= 5;
//    }
//}


//}



//string text = "Salom, Dunyo!";
//string[] words = text.Split(' ');

//foreach (string word in words)
//{
//    char firstCharacter = word[0];

//    if (char.IsUpper(firstCharacter))
//    {
//        Console.WriteLine($"{word} - Katta harf bilan boshlangan so'z");
//    }
//    else if (char.IsLower(firstCharacter))
//    {
//        Console.WriteLine($"{word} - Kichik harf bilan boshlangan so'z");
//    }
//    else
//    {
//        Console.WriteLine($"{word} - Belgi so'z emas");
//    }
//}
//    }
//}