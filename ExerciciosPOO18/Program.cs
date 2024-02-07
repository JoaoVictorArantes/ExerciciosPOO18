using ExerciciosPOO18.Entities;

namespace ExerciciosPOO18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            String Name = Console.ReadLine();

            Console.Write("Initial balance: ");
            double InitialBalance = double.Parse(Console.ReadLine());

            Console.Write("Withdraw limit: ");
            double WithdrawLimit = double.Parse(Console.ReadLine());

            Account Account = new Account(number, Name, InitialBalance, WithdrawLimit);

            Console.WriteLine("\nEnter amount for withdraw: ");
            double Withdraw = double.Parse(Console.ReadLine());

            try
            {
                Account.Withdraw(Withdraw);
                Console.WriteLine("New balance: " + Account.Balance.ToString("F2"));

            } catch (Exception ex)
            {
                Console.WriteLine("Withdraw error: " + ex.Message);
            }

            Console.ReadKey();
            Console.Beep();
        }
    }
}
