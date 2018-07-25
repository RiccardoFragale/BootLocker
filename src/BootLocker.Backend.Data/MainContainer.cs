using System.Data.Entity;
using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Backend.Data
{
    public class MainContainer : DbContext
    {
        public MainContainer()
            : base("name=MainContainer")
        {
        }

        public virtual DbSet<ElementCategory> Categories { get; set; }
    }
}