using System.Xml.Serialization;

namespace Xml
{
    public class Plants
    {
        [XmlElement("plants")]
        public string Plant { get; set; }

        [XmlElement("common")]
        public string Common { get; set; }

        [XmlElement("botanical")]
        public string Botanical { get; set; }

        [XmlElement("zone")]
        public string Zone { get; set; }

        [XmlElement("light")]
        public int Light { get; set; }

        public override string ToString()
        {
            return $"{nameof(Plant)}:{Plant}; " +
                   $"{nameof(Common)}:{Common}; " +
                   $"{nameof(Botanical)}:{Botanical}; " +
                   $"{nameof(Zone)}:{Zone}; " +
                   $"{nameof(Light)}:{Light};";
        }
    }
}
