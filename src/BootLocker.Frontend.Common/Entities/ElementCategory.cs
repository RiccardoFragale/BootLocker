using System;
using System.Runtime.Serialization;

namespace BootLocker.Frontend.Common.Entities
{
    [DataContract]
    public class ElementCategory
    {
        public int Id { get; set; }

        public Guid GuId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}