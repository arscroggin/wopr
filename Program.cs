using System.Threading;


namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var name = Console.ReadLine();
      var currentDate = DateTime.Now;
      WriteTerminal($"{Environment.NewLine}Greetings {name}, on {currentDate:d} at {currentDate:t}!\n");

      Console.WriteLine("Would you like to play a game?");
      var answer = Console.ReadLine();

      PrintGames();
      ExitProgram();

    }


    private static void ExitProgram()
    {
      Console.Write($"{Environment.NewLine}Press any key to exit...");
      Console.ReadKey(true);
    }

    private static void PrintGames()
    {
      Console.WriteLine("Chess");
      Console.WriteLine("Poker");
      Console.WriteLine("Fighter Combat");
      Console.WriteLine("Guerrilla Engagement");
      Console.WriteLine("Desert Warfare");

      Console.WriteLine("\nGlobal Thermonuclear War");

    }

    private static void WriteTerminal(string outString)
    {
      foreach (char c in outString)
      {
          Console.Write(c);
          Thread.Sleep(140);
      }
    }
  }
}