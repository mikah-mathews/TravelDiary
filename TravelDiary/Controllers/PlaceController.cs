using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TravelDiary.Models;

namespace TravelDiary.Controllers
{
  public class PlaceController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string countryName, string travelCompanions, string travelEntry, string travelDate)
    {
      Place place = new Place(cityName, countryName, travelCompanions, travelEntry, travelDate);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult Delete()
    {
      Place.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }
  }
}