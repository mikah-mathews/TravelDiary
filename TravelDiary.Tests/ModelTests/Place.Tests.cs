using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelDiary.Models;
using System;

namespace TravelDiary.TestTools
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
      {
        Place.ClearAll();
      }
  
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place place = new Place("Boise");
      Assert.AreEqual(typeof(Place), place.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      //Arrange
      string cityName = "Seattle";

      //Act
      Place newPlace = new Place(cityName);
      string result = newPlace.CityName;

      //Assert
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      //Arrange
      string cityName = "Seattle";
      Place newPlace = new Place(cityName);

      //Act
      string updatedCityName = "Portland";
      newPlace.CityName = updatedCityName;
      string result = newPlace.CityName;

      //Assert
      Assert.AreEqual(updatedCityName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      // Arrange
      List<Place> newList = new List<Place> { };

      // Act
      List<Place> result = Place.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      //Arrange
      string cityName01 = "Seattle";
      string cityName02 = "Portland";
      Place newPlace1 = new Place(cityName01);
      Place newPlace2 = new Place(cityName02);
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };

      //Act
      List<Place> result = Place.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string cityName = "Portland";
      Place newPlace = new Place(cityName);

      //Act
      int result = newPlace.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      //Arrange
      string cityName01 = "Seattle";
      string cityName02 = "Portland";
      Place newPlace1 = new Place(cityName01);
      Place newPlace2 = new Place(cityName02);

      //Act
      Place result = Place.Find(2);

      //Assert
      Assert.AreEqual(newPlace2, result);
    }
  }
}