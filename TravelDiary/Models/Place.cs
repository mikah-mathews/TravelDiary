using System.Collections.Generic;

namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }

    // public string CountryName { get; set; }

    public int Id { get; }
    
    private static List<Place> _instances = new List<Place> {};

    public Place(string cityName)
    {
      CityName = cityName;
      // CountryName = countryName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}