using System;
using System.Collections.Generic;

namespace Zaj2
{
    public class ContainerHolder
    {
        private List<Container> _containers = new List<Container>();

        public ContainerHolder() { }

        public void ShowContainerList()
        {
            Console.WriteLine("=== CONTAINER LIST ===");
            for (int i = 0; i < _containers.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _containers[i].GetContainerSerialNumber());
            }
        }

        public Container GetContainer()
        {
            
        }
        
    }
}