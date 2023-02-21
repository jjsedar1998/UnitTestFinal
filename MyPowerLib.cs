using static System.Console;
namespace MyPowerLib
{
    public class Power
    {
        public static double MyPowerOf2(double num, double num1)
        {
            double power;
            power = Math.Pow(num, num1);

            Console.WriteLine(num + " to the power of " + num1 + " is " + power);
            return power;
        }
        public static double MyPowerOf3(double num, double num1, double num2)
        {
            double power;
            power = Math.Pow(num, Math.Pow(num1, num2));

            Console.WriteLine(num + " to the power of " + num1 + " to the power of " + num2 + " is " + power);
            return power;
        }
    }
}