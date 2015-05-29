using System;

namespace ConsoleProject.Creational
{
    public class CarBuilder
    {
        private readonly Car _car = new Car();

        public Car GetCar()
        {
            return _car;
        }

        public CarBuilder SetSeatCount(int numberOfSeats)
        {
            _car.SeatCount = numberOfSeats;
            return this;
        }

        public CarBuilder SetCarType(CarType carType)
        {
            _car.CarType = carType;
            return this;
        }

        public CarBuilder SetHasGps(bool hasGps)
        {
            _car.HasGps = hasGps;
            return this;
        }

        public CarBuilder SetHasTripComputer(bool tripComputer)
        {
            _car.HasTripComputer = tripComputer;
            return this;
        }
    }

    public class Car
    {
        public bool HasGps { get; set; }
        public bool HasTripComputer { get; set; }
        public CarType CarType { get; set; }
        public int SeatCount { get; set; }

        public override string ToString()
        {
            var result =
                "Has GPS: {0}" + Environment.NewLine +
                "Has trip computer: {1}" + Environment.NewLine +
                "Car type: {2}" + Environment.NewLine +
                "Seat count: {3}";
            return string.Format(result, HasGps, HasTripComputer, CarType, SeatCount);
        }
    }

    public enum CarType
    {
        Sport,
        Cabriolet,
        City
    }
}
