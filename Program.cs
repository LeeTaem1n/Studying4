using System;
namespace RemoveWhiteSpace
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            char[] WhiteSpace = { ' ', '\n', '\t' };
            string s = " this is a\nstring";
            Console.WriteLine("Before:" + s );
            Console.WriteLine("After:");
            for (; ; )
            {
                int offset = s.IndexOfAny(WhiteSpace);
                if (offset == -1)
                {
                    break;
                }    
                string before = s.Substring(0, offset);
                string after = s.Substring(offset + 1);
                s = string.Concat(before, after);
            }
            Console.WriteLine(s);
            Console.WriteLine("Press 'Enter' to over");
            Console.Read(); 
        }
    }
}