using System;

namespace Delegates
{
    class Program
    {
        public delegate void PerformSelection(int r, int s);

        static void Main(string[] args)
        {
            PerformSelection pointer;

            MyShow theTask = new MyShow();

            pointer = theTask.SumOfInt;
            pointer += theTask.Subtract;
            pointer += delegate (int x, int t) {
               Console.WriteLine(x * t);
                     };
            pointer += (int f, int g) => {
                Console.WriteLine(f / g);

            };

            pointer -= theTask.SumOfInt;
            pointer -= theTask.Subtract;

            pointer(4, 3);

        }
    }
}
public class MyShow
{
    public void SumOfInt(int parameter1, int parameter2)
    {
        Console.WriteLine(parameter1 + parameter2);
    }
    public void Subtract(int x, int y)
    {
        Console.WriteLine(x - y);
    }

}