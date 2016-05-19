using System.IO;
using System.Xml.Serialization;

namespace Paint.Classes
{
    public class XmlSerialize
    {
        private XmlSerializer formatter;

        public XmlSerialize()
        {
            this.formatter = new XmlSerializer(typeof (StoreFigures));
        }

        public void SerializeStore(StoreFigures storeFigures)
        {
            using (var fileStream = new FileStream("storage.xml", FileMode.Create))
            {
                formatter.Serialize(fileStream, storeFigures);
            }
        }

        public StoreFigures DeserializeStore()
        {
            using (var fileStream = new FileStream("storage.xml", FileMode.Open))
            {
                return (StoreFigures) formatter.Deserialize(fileStream);
            }

        }
    }
}
