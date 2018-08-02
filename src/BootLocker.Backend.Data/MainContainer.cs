using System.Collections.Generic;
using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Backend.Data
{
    public class MainContainer
    {
        public MainContainer()
        {
            Categories = new List<ElementCategory>();
        }

        public List<ElementCategory> Categories { get; set; }
    }
}