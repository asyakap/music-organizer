using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Track
  {
    public string TrackName { get; set; }
    public int Id { get; }
    private static List<Track> _instances = new List<Track> { };

    public Track(string trackName)
    {
      TrackName = trackName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Track> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Track Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }

}