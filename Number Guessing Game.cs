namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            int attempts = 3;

            for (int i = 1; i <= attempts; i++)
            {
                Console.Write("Enter your guess: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine(" You win");
                    return;
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Too low");
                }
            }

            Console.WriteLine("Game Over! The number was 42");
        }
    }
}
    

