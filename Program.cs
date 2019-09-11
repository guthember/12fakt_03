using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // ez kell!!!!

namespace ismetlesFile
{
  class Program
  {
    static void Main(string[] args)
    {
      // 100 adatnál nincs több a fájlban!
      int[] tomb = new int[100];
      int db = 0; // a tényleges darabszám jelölése

      StreamReader be = new StreamReader("adatok.txt");

      // amíg a file végéig nem érünk
      while (!be.EndOfStream)
      {
        tomb[db] = Convert.ToInt32(be.ReadLine());
        db++;
      }

      be.Close(); // erőforrás bezárása

      Console.WriteLine("Az elemek darabszáma: {0}",db);
      Console.WriteLine("Elemek: ");
      for (int i = 0; i < db; i++)
      {
        Console.WriteLine(tomb[i]);
      }

      Console.ReadKey();

    }
  }
}
