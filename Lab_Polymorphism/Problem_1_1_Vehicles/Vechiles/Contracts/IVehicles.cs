namespace Problem_1_1_Vehicles.Contracts
{
    public interface IVehicles
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double TankCapacity { get; }
        bool IsVehicleEmty { get; set; }

        void Driven(double distance);
        void Refueled(double litters);

    }
}
