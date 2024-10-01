using System.Linq;

namespace DemoLambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };
            foreach (string item in names.OrderBy(s => s))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nname that contain a:");
            var items =  from word in names
                         where word.Contains("a")
                         select word;
            foreach (string s in items)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
