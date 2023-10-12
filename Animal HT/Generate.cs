using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerate
{
    public class Generate
    {
        public string Generator(int length, bool hasLetter, bool hasdigit)
        {
            var password = new StringBuilder();
            if(!hasLetter && hasdigit)
            {
                var random = new Random();

                var number = random.Next(length);
                password.Append(number);
                return password.ToString();
            }
            if(hasLetter && !hasdigit)
            {
                List<string> passwordList = new List<string>();
                Random random = new Random();

                string letters = "asdfghjklqwertyuiozxcvbnmp";

                int i = 0;
                while(passwordList.Count < )
            }
            //    var string1 = new StringBuilder();
            //    string1.Append(guid.ToString());
            //}

            //for (var index = 0; index < length;)
            //{

            //    if (hasdigit && random.Next(0, 2) == 0)
            //    {
            //        var randomDigit = random.Next(0, 10);
            //        password.Append(randomDigit);

            //        index++;
            //    }
            //    else if (hasLetter)
            //    {
            //        var randomChar = random.Next(0, 1) == 0
            //            ? (char)random.Next(97, 123)
            //            : (char)random.Next(65, 91);
            //        index++;

            //        password.Append(randomChar);
            //    }
            //}
            //return "";
        }
}
