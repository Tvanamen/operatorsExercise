using System;
namespace OperatorExercise
{
    internal class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers you would like added together");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int add = addition(num1, num2);
            Console.WriteLine(add);

            Console.WriteLine("Please enter two numbers you would like subracted from each other");
            double num3 = int.Parse(Console.ReadLine());
            double num4 = int.Parse(Console.ReadLine());
            double sub = subtraction(num3, num4);
            Console.WriteLine(subtraction);

            Console.WriteLine("Please enter two numbers you would like mutiplyed together");
            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            int mut = multiplication(num5, num6);
            Console.WriteLine(mut);

            //Console.WriteLine("Last but not least enter two numbers to divide");
            //int num7 = int.Parse(Console.ReadLine());
            //int num8 = int.Parse(Console.ReadLine());
            var num7 = 17;
            int num8 = 4;
            int div = division(num7, num8);
            var mod = remainder(num7, num8);
            Console.WriteLine($"{num7}/{num8} is {div} with a remainder of {mod}");
            //Console.WriteLine(mod);

            Console.WriteLine("Please enter the radius of the circle you would like the area of.");
            int radius = int.Parse(Console.ReadLine());
            var area = calculateArea(radius);
            Console.WriteLine(area);

        }
        public static int addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public static double subtraction(double num3, double num4)
        {
            return num3 - num4;
        }
        public static int multiplication(int num5, int num6)
        {
            return num5 * num6;
        }
        public static int division(int num7, int num8)
        {
            return num7 / num8;
        }
        public static int remainder(int num7, int num8) 
        { 
        return (num7 % num8);
        }
        public static double calculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
