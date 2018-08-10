using System;
using System.Collections.Generic;
using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Frontend.Common
{
    public class AppContext 
    {
        public AppContext()
        {
            Categories = new List<ElementCategory> {
               new ElementCategory {Id = 1, Name = "Category1", GuId = Guid.NewGuid() },
               new ElementCategory {Id = 3, Name = "Category2", GuId = Guid.NewGuid() , Description = "test category" }
            };
        }

        public List<ElementCategory> Categories { get; set; }
    }
}