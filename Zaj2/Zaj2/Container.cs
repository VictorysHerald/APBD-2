// Container is responsible for general fuctions of all containers
// It is a parent class for all container subtypes

using System;

namespace Zaj2
{
    abstract class Container
    {
        private double mass;            // kg
        private double height;          // cm
        private double emptyWeight;    // kg
        private double depth;           // cm
        private double maxCapacity;     // kg
        private String serialNumber;    // KON-<type(L,G,C)>-<num>

        protected Container(double mass, double height, double emptyWeight, double depth, double maxCapacity, string serialNumber)
        {
            this.mass = mass;
            this.height = height;
            this.emptyWeight = emptyWeight;
            this.depth = depth;
            this.maxCapacity = maxCapacity;
            this.serialNumber = serialNumber;
        }

        // Unloads the given container
        private void UnloadContainer()
        {
            
        }
        
    }
}