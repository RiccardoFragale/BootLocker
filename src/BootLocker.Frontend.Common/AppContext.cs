using System.Collections.Generic;
using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Frontend.Common
{
    public class AppContext 
    {
        public AppContext()
        {
            Categories = new List<ElementCategory>();
        }

        public List<ElementCategory> Categories { get; set; }
    }
}