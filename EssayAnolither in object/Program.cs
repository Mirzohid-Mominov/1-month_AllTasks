var essay = new Document();
essay.Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!";
var analizer = new DocumentAnalyzer();
Console.WriteLine($"ball: {analizer.Anolize(essay)}");

// model
public class Document
{
    public string Content;

}
// service
public class DocumentAnalyzer
{
    public int Anolize(Document content)
    {
        int ball = 100;
        string essay = content.Content;
        var words = essay.Split(' ');
        var sentences = essay.Split('.', '!', '?');
        if(words.Length < 500) {
            ball -= 5;
        }
        var word2 = essay.Split(' ');
        foreach( var sentence in sentences )
        {
            var wordsb = sentence.Split(' ');
            var formatword = string.Concat(
                wordsb[0].Substring(0, 1).ToUpper(),
                wordsb[0].Substring(1).ToLower()
                );
            if (wordsb[0] != formatword)
            {
                ball -= 5;
            }
        }

        foreach( var sentence in sentences )
        {
            var wordsb = sentence.Split(' ');
            for(int i = 1; i <  wordsb.Length-1; i++) 
            {

                if (wordsb[i] != wordsb[i].ToLower())
                {
                    ball -= 10;
                }
            }
        }

        for (int i = 0; i < words.Length - 1; i++)
        {
            int num = 0;
            for (int j = i; j < words.Length - 1; j++)
            {
                if (words[i] == words[j])
                {
                    num += 1;
                }
            }
            if (num >= 100)
            {
                ball -= 5;
            }
        }


        return ball;
        
    }
}

















//public class essayAnolither
//{
//    public essayAnolither(int Word, int Ball, string essay, string AllWords, char Letter) 
//    {
//        word = Word;
//        ball = Ball;
//        Essay = essay;
//        allWords = AllWords;
//        letter = Letter;


//    }
//    public int word;
//    public int ball;
//    public string Essay;
//    public string allWords;
//    public char letter;
//}


