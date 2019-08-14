using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This lotto program allows the player to 'lot' numbers at random and print the numbers which he has 'lotted' or picked at random.
/// </summary>
namespace ListLottery
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Stebuks Lotto Program");
      Console.WriteLine();
      Lottery myLottery = new Lottery();
      char choice = '0';
      //Main loop
      while (choice != '3')
      {
        Console.WriteLine("1 - Lot the next number");
        Console.WriteLine("2 - Print selected numbers");
        Console.WriteLine("3 - Quit");
        choice = Console.ReadKey().KeyChar;
        Console.WriteLine();
        //reaction to choice
        switch (choice)
        {
          case '1':
            Console.WriteLine("You got: {0}", myLottery.Lot());
            break;
          case '2':
            Console.WriteLine("Numbers drawn: {0}", myLottery.Print());
            break;
          case '3':
            Console.WriteLine("Thanks for using our lotto program. Press any key to exit lotto program...");
            break;
          default:
            Console.WriteLine("Invalid option. Please try again...");
            break;
        }
        Console.ReadKey(true);

      }
    }
  }
}
