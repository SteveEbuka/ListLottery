using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This class has the methods for generating numbers at random from 1 to 100 and printing the selected
/// randomly generated program.
/// </summary>
namespace ListLottery
{
  class Lottery
  {
    private Random random = new Random();
    private List<int> lotList = new List<int>();

    public int Lot()
    {
      int num = random.Next(100) + 1;
      lotList.Add(num);
      return num;
    }

    public string Print()
    {
      string s = "";
      lotList.Sort();
      foreach (int i in lotList)
      {
        s += i + " ";
      }
      return s;
    }

  }
}
