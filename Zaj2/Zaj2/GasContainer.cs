namespace Zaj2.Properties
{
    public class GasContainer : Container
    {
        private double pressure;
        public GasContainer(double cargoMass, double height, double emptyWeight, double depth, double maxCapacity, string serialNumber)
            : base(cargoMass, height, emptyWeight, depth, maxCapacity, serialNumber)
        {
            
            
        }

        // SetPressure() - sets pressure in container
        public void SetPressure(double p)
        {
            this.pressure = p;
        }
    }
}