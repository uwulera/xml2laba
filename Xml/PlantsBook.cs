using System.Collections.Generic;
using System.Xml.Serialization;

namespace Xml
{
    [XmlRoot("plantsbook")]
    public class PlantsBook
    {
        [XmlElement("plants")]
        public List<Plants> Items { get; set; }
    }
}
