using System;

namespace Reverse4
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 1, second = 2, third = 3, fourth = 4;
            Console.WriteLine("before: first int {0}, second int {1}, third int {2}, fourth int {3}", first, second, third, fourth);
            Reverse(ref first, ref second, ref third, ref fourth);
            Console.WriteLine("after: first int {0}, second int {1}, third int {2}, fourth int {3}", first, second, third, fourth);
        }

        static void Reverse(ref int one, ref int two, ref int three, ref int four)
        {
            int tmp;
            tmp = one;
            one = four;
            four = tmp;
            tmp = two;
            two = three;
            three = tmp;
        }
    }
}
