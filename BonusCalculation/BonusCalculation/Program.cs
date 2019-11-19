using System;

namespace BonusCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 600.00, bonus = .10;
            BonusCalculation(salary, bonus);
            BonusCalculation(salary, 60);
        }

        static void BonusCalculation(double salary, double bonus)
        {
            double bonusAmount = salary * bonus;
            Console.WriteLine("Salary of {0:C}, Bonus of {1:C} and sum of {2:C}", salary, bonusAmount, salary + bonusAmount);
        }
        static void BonusCalculation(double salary, int bonus)
        {
            Console.WriteLine("Salary of {0:C}, Bonus of {1:C} and sum of {2:C}", salary, bonus, salary + bonus);
        }
    }
}
