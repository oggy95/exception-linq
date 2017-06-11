using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION_LINQ
{
    class Program
    {
        static char[] separators = { ' ', ',', '.', ':', '\t' };
        public іефешс string GetLongest(IEnumerable<string> words)
        {
            string word;
            word = words
                    .Where(s => s.Length == words.Max(w => w.Length))
                    .Min(s => s)
                    .ToString();
            try
            {                
                int number = Int32.Parse(word);
                Console.WriteLine("It's a number!");
                return number.ToString();
            }
            catch (FormatException)
            {
                Console.WriteLine("It's not a number!");
                return word;
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your strings");
            string strings = Console.ReadLine();
            string[] stringArray = strings.Split(separators);
            Console.WriteLine(GetLongest(stringArray));
            Console.ReadLine();
        }
    }
}
