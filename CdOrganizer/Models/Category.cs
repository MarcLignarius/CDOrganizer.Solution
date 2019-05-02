using System;
using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class Artist
  {
    private static List<Artist> _instances = new List<Artist> {};
    private string _name;
    private int _id;
    private List<CD> _CD;

     public Artist(string artistName)
     {
       _name = artistName;
       _instances.Add(this);
       _id = _instances.Count;
       _CD = new List<CD>{};
     }

     public string GetName()
     {
       return _name;
     }
     public static List<Artist> GetAll()
     {
       return _instances;
     }
    public int GetId()
    {
      return _id;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
