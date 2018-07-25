using System.Data.Entity;
using BootLocker.Frontend.Common.Entities;

namespace BootLocker.Frontend.Common
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