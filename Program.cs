using System;
using System.Linq;

namespace EFSQLite
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var context = new ChinookContext())
      {
        var artistStartingWithA = context.Artists
          .Where(x => StartsWith(x, "A"))
          .OrderBy(x => x.Name);

        foreach (var artist in artistStartingWithA)
          Console.WriteLine(artist.Name);
      }
    }

    static bool StartsWith(Artist a, string initial)
    {
      return a.Name.StartsWith(initial, StringComparison.CurrentCulture);
    }
  }
}
