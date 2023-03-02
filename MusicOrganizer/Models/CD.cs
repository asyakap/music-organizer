using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class CD
  {
    private static List<CD> _instances = new List<CD> { };
    public string Name { get; set; }
    public string Artist { get; set; }
    public int Id { get; }
    public List<Track> Tracks { get; set; }

    public CD(string cdName, string cdArtist)
    {
      Name = cdName;
      Artist = cdArtist;
      _instances.Add(this);
      Id = _instances.Count;
      Tracks = new List<Track> { };
    }

    public static List<CD> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void AddTrack(Track track)
    {
      Tracks.Add(track);
    }

    public static CD Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static List<CD> FindByArtist(string artist)
    {
      List<CD> list = new List<CD> { };
      foreach (CD cd in _instances) 
      {
        if (cd.Artist == artist) 
        {
          list.Add(cd);
        }
      }
      return list;
    }
  }
}
