using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
            Console.WriteLine(CreateMessage("this is your message now"));
        }

        public static string CreateMessage()
        {
            return "Hello World!";
        }

        public static string CreateMessage(string message) => message;
    }
}
