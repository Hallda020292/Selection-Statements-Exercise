namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int FavNumber = 5;
            Console.WriteLine("try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput > FavNumber)
            {
                Console.WriteLine("too high");
            }
            if (userInput < FavNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput == FavNumber)
            {
                Console.WriteLine("nevermind you got it correct!");
            }
                }

        }
    }
