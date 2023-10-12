
using System.Text;

var generator = new PasswordGenerator(10, true, true);
public class PasswordGenerator
{
    private readonly int length;
    private readonly bool hasLetter;
    private readonly bool hasDigit;

    public PasswordGenerator(int length, bool hasLetter, bool hasDigit)
    {
        if (length < 0 || (hasLetter == false && hasDigit == false))

            this.length = length;
        this.hasLetter = hasLetter;
        this.hasDigit = hasDigit;
    }
    public string Generator()
    {
        var random = new Random();
        var password = new StringBuilder();

        for (var index = 0; index < length;)
        {


            if (hasDigit && random.Next(0, 2) == 0)
            {
                var randomDigit = random.Next(0, 10);
                password.Append(randomDigit);

                index++;
            }
            else if (hasLetter)
            {
                var randomChar = random.Next(0, 1) == 0
                    ? (char)random.Next(97, 123)
                    : (char)random.Next(65, 91);
                index++;

                password.Append(randomChar);
            }
        }
        return "";
    }


}

public class SecurePasswordGeneratror : PasswordGenerator
{
    public SecurePasswordGeneratror(int length, bool hasLetter, int hasDigit)
        : base(length, hasLetter, hasDigit)
    {

    }


}

