using System.Collections.Generic;

namespace CdOrganizer.Models
{
  public class CD
  {
    private string _title;
    private static List<CD> _instances = new List<CD> {};

    public CD (string title)
    {
      _title = title;
      _instances.Add(this);
    }

    public string GetTitle()
    {
      return _title;
    }

    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public static List<CD> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
