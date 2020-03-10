using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public string Message { get; set; }
    
    private static List<Car> _models = new List<Car> {};

    public Car(string makeModel, int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
      _models.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _models;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (Price<=maxPrice && Miles<=maxMiles);
    }
  } 
}


