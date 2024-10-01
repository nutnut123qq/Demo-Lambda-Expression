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
            Console.ReadLine();
        }
    }
}
