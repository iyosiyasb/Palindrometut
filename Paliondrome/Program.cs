using System;

namespace Paliondrome
{
    class Program
    {
        static void Main(string[] args)
        {
			string a = string.Empty;
            Console.WriteLine("Enter string");
			a = Console.ReadLine();

			Char[] Temp = a.ToCharArray();
			Array.Reverse(Temp);
			string b = new string(Temp);

			if (a.ToLower().Equals(b.ToLower()))
			{
				Console.WriteLine("Palindrome");
			}
			else
			{
				Console.WriteLine(" Not a Palindrome");
			}
			Console.ReadLine();
        }
    }
}
