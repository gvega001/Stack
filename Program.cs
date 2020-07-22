using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack theStack = new Stack(4);
            theStack.push("Star Wars");
            theStack.push("Jaws");
            theStack.push("Dumb and Dumber");
            theStack.push("Jaws 2");
            theStack.push("Ace Ventura");
           

            WriteLine("=================\n About to peek:\n");

            WriteLine("'"+theStack.peek() + "'"+"is as the top of the stack");


            WriteLine("=================\n The Stack contains:\n");

            while (!theStack.isEmpty() )
            {
                string movie = theStack.pop();
                WriteLine(movie);  
            }
            Thread.Sleep(3000);
        }
    }
}
