using System.Collections.Generic;

namespace EFSQLite
{
  public sealed class Artist
  {
    public Artist()
    {
      Albums = new List<Album>();
    }

    public long ArtistId { get; set; }
    public string Name { get; set; }

    public ICollection<Album> Albums { get; set; }
  }
}
