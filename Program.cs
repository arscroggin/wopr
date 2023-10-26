using System.Threading;


namespace Adam.Scroggin.WOPR
{
  /// <summary>
  /// Rewrite of the WOPR in C#
  /// </summary>
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      DisplayGreetings();
      CheckGames();
      PlayGlobalThermoWar();
      ExitProgram();
    }

    private static void DisplayGreetings()
    {
      WriteTerminal("WELCOME TO THE WOPR\n\n");
      WriteTerminal("What is your name? ");
      var name = Console.ReadLine();
      var currentDate = DateTime.Now;
      WriteTerminal($"{Environment.NewLine}Greetings {name}, on {currentDate:d} at {currentDate:t}!\n");
    }

    private static void ExitProgram()
    {
      Console.Write($"{Environment.NewLine}Press any key to exit...");
      Console.ReadKey(true);
    }

    private static void CheckGames()
    {
      WriteTerminal("SHALL WE PLAY A GAME? ");
      var answer = Console.ReadLine();
      char firstLetter = answer.ToLowerInvariant()[0]; 
      Console.WriteLine(firstLetter); 

      if (firstLetter.Equals('y'))
      {
        PrintGames();
        answer = Console.ReadLine();
        WriteTerminal("\nWOULDN'T YOU PREFER A GOOD GAME OF CHESS? ");
        answer = Console.ReadLine();
        WriteTerminal("FINE.");
        Thread.Sleep(1400);
      }
    }

    private static void PrintGames()
    {
      Console.Clear();
      Console.WriteLine("Chess");
      Console.WriteLine("Poker");
      Console.WriteLine("Fighter Combat");
      Console.WriteLine("Guerrilla Engagement");
      Console.WriteLine("Desert Warfare");
      Console.WriteLine("Air-To-Ground Actions");
      Console.WriteLine("Theaterwide Tactical Warfare");
      Console.WriteLine("Theaterwide Biotoxic and Chemical Warfare");

      Console.WriteLine("\nGlobal Thermonuclear War");
    }

    private static void WriteTerminal(string outString, int timeDelay = 80)
    {
      foreach (char c in outString)
      {
          Console.Write(c);
          Thread.Sleep(timeDelay);
      }
    }

    private static void PlayGlobalThermoWar()
    {
      Console.Clear();
      PrintUSA();

      WriteTerminal("WHICH SIDE DO YOU WANT?\n\n");
      WriteTerminal("1.   UNITED STATES\n");
      WriteTerminal("2.   SOVIET UNION\n\n");

      var answer = Console.ReadLine();
    }

    private static void PrintUSA()
    {
      const int TimeDelayInMillis = 5;
      WriteTerminal("    ,__                                                 _,\n", TimeDelayInMillis);
      WriteTerminal(" \\~\\|  ~~---___              ,                          | \\\n", TimeDelayInMillis);
      WriteTerminal("  |      / |   ~~~~~~~|~~~~~| ~~---,                  _/,  >\n", TimeDelayInMillis);
      WriteTerminal(" /~-_--__| |          |     \\     / ~\\~~/          /~| ||,'\n", TimeDelayInMillis);
      WriteTerminal(" |       /  \\         |------|   {    / /~)     __-  ',|_\\,\n", TimeDelayInMillis);
      WriteTerminal("/       |    |~~~~~~~~|      \\    \\   | | '~\\  |_____,|~,-'\n", TimeDelayInMillis);
      WriteTerminal("|~~--__ |    |        |____  |~~~~~|--| |__ /_-'     {,~\n", TimeDelayInMillis);
      WriteTerminal("|   |  ~~~|~~|        |    ~~\\     /  `-' |`~ |~_____{/\n", TimeDelayInMillis);
      WriteTerminal("|   |     |  '---------,      \\----|   |  |  ,' ~/~\\,|`\n", TimeDelayInMillis);
      WriteTerminal("',  \\     |    |       |~~~~~~~|    \\  | ,'~~\\  /    |\n", TimeDelayInMillis);
      WriteTerminal("  |   \\    |    |       |       |     \\_-~    /`~___--\\\n", TimeDelayInMillis);
      WriteTerminal("  ',   \\  ,-----|-------+-------'_____/__----~~/      /\n", TimeDelayInMillis);
      WriteTerminal("    '_   '\\|     |      |~~~|     |    |      _/-,~~-,/\n", TimeDelayInMillis);
      WriteTerminal("      \\    |     |      |   |_    |    /~~|~~\\    \\,/\n", TimeDelayInMillis);
      WriteTerminal("       ~~~-'     |      |     `~~~\\___|   |   |    /\n", TimeDelayInMillis);
      WriteTerminal("           '-,_  | _____|          |  /   | ,-'---~\\\n", TimeDelayInMillis);
      WriteTerminal("               `~'~  \\             |  `--,~~~~-~~,  \\\n", TimeDelayInMillis);
      WriteTerminal("                      \\/~\\      /~~~`---`         |  \\\n", TimeDelayInMillis);
      WriteTerminal("                          \\    /                   \\  |\n", TimeDelayInMillis);
      WriteTerminal("                           \\  |                     '\\'\n", TimeDelayInMillis);
      WriteTerminal("                            `~'\n", TimeDelayInMillis);
    }
  }
}