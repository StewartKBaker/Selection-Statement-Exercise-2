namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite School Subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math was always one of my best subjects!");
                    break;
                case "science":
                    Console.WriteLine("Science was a lot of fun, especially physics!");
                    break;
                case "english":
                    Console.WriteLine("English was fun!");
                    break;
                case "social studies":
                    Console.WriteLine("The class I fell asleep in the most");
                    break;
                case "art":
                    Console.WriteLine("Let that creative side flow!");
                    break;
                default:
                    Console.WriteLine($"Oh, I must have forgot about {favSubject}!");
                    break;
            }
        }
    }
}