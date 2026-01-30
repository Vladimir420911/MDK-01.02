using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class CarRepo
    {
        private List<Car> cars = new List<Car>();

        public List<Car> GetAllCars()
        {
            return cars;
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }
    }
}
