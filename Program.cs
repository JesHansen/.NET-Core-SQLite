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
        var artists = from a in context.Artists
                      where a.Name.StartsWith("A")
                      orderby a.Name
                      select a;

        foreach (var artist in artists)
        {
          Console.WriteLine(artist.Name);
        }
      }
    }
  }
}
