// Container is responsible for general fuctions of all containers
// It is a parent class for all container subtypes

using System;

namespace Zaj2
{
    public class Container
    {
        private double cargoMass;            // kg
        private double height;          // cm
        private double emptyWeight;    // kg
        private double depth;           // cm
        private double maxCapacity;     // kg
        private String serialNumber;    // KON-<type(L,G,C)>-<num>

        protected Container(double cargoMass, double height, double emptyWeight, double depth, double maxCapacity, string serialNumber)
        {
            this.cargoMass = cargoMass;
            this.height = height;
            this.emptyWeight = emptyWeight;
            this.depth = depth;
            this.maxCapacity = maxCapacity;
            this.serialNumber = serialNumber;
        }

        // UnloadContainer() - Unloads the given container
        // To be overriden in subclasses with product type that was unloaded
        public void UnloadContainer()
        {
            Console.WriteLine("Unloaded container: " + serialNumber);
            Console.WriteLine("Unloaded cargo: " + cargoMass);
            
        }
        
        // LoadContainer() - Loads a given container with specified amount of cargo
        public void LoadContainer()
        {
            Console.WriteLine();
        }

        public String GetContainerSerialNumber()
        {
            return this.serialNumber;
        }
    }
}