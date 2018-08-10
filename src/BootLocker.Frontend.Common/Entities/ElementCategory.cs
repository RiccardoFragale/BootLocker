using System;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace BootLocker.Frontend.Common.Entities
{
    [DataContract]
    public class ElementCategory
    {
        public int Id { get; set; }

        [ScriptIgnore]
        [DataMember]
        public Guid GuId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}