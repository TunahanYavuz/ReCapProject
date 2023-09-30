using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { CarName = "Audi A7", BrandID = 1, CarID = 1, ColorID = 2050, DailyPrice = 1800,Description="2016 Model Audi A7",ModelYear=(char)2016 },
                new Car { CarName = "Audi A4", BrandID = 1, CarID = 2, ColorID = 1532, DailyPrice = 800,Description="2010 Model Audi A4",ModelYear=(char)2010 },
                new Car { CarName = "Ford Mustang", BrandID = 2, CarID = 3, ColorID = 7854, DailyPrice = 2000,Description="2017 Model Ford Mustang",ModelYear=(char)2017 },
                new Car { CarName = "Mercedes AMG", BrandID = 3, CarID = 4, ColorID = 6545, DailyPrice = 5000,Description="2022 Model Mercedes AMG",ModelYear=(char)2022 }
            };
        }

        

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete  = _cars.SingleOrDefault(c=>c.CarID == car.CarID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetBylD(int ID)
        {
            return _cars.Where(c => c.CarID == ID).ToList();
        }

        public List<Car> GetCars()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c=>c.CarID==car.CarID);
            _cars.
        }
    }
}
