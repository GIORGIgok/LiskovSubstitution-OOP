namespace LiskovSubstitution
{
    // A base class for vehicles that drive on roads.
    public abstract class RoadVehicle
    {
        public abstract void Drive();
    }

    // A class for vehicles that can float on water.
    public abstract class WaterVehicle
    {
        public abstract void Float();
    }

    // A subclass that represents a car, which drives on the road.
    public class Car : RoadVehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driving on the road!");
        }
    }

    // A subclass that represents a boat, which floats on water.
    public class Boat : WaterVehicle
    {
        public override void Float()
        {
            Console.WriteLine("Boat is floating on the water!");
        }
    }
}

// Car and Boat are in separate hierarchies (RoadVehicle and WaterVehicle).
// Each subclass can be used without breaking any expectations.

// By ensuring each subclass can replace its base class without causing errors,
// we follow the Liskov Substitution Principle, making the code more robust and predictable.