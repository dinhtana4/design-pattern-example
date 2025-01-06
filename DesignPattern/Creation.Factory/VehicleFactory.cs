namespace Creation.Factory
{
    /// <summary>
    /// defines an interface for creating an object, but let subclasses decide which class to instantiate. This pattern lets a class defer instantiation to subclasses.
    /// </summary>
    public class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            return vehicleType.ToLower() switch
            {
                "car" => new Car(),
                "bike" => new Bike(),
                "truck" => new Truck(),
                _ => throw new Exception("Invalid vehicle type")
            };

        }
    }
}
