using System;
using System.Text;

namespace StringsEx25
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "My email is anca.ticau@gmail.com";
            Console.WriteLine(ObfuscateEmail(givenString));
        }

        //You have some text that contains your email address.And you want to hide that.
        //You decide to censor your email: to replace all characters in it with asterisks ('*') except the domain.Assume your email address will always be in format[username]@[domain]. 
        //You need to replace the username with asterisks of equal number of letters and keep the domain unchanged.You will get as input the email address you need to obfuscate

        public static string ObfuscateEmail(string input)
        {
            StringBuilder obfuscated = new StringBuilder();
            bool atCharFound = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '@')
                {
                    obfuscated.Append('@');
                    atCharFound = true;
                    continue;
                }

                if (atCharFound == false)
                {
                    obfuscated.Append('*');
                    continue;
                }

                obfuscated.Append(input[i]);
            }

            return obfuscated.ToString();
        }
    }
}
