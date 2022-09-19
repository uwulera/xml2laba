using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace Xml
{
    public partial class Form1 : Form
    {
        [XmlRoot(Namespace = "http://scap.nist.gov/schema/feed/vulnerability/2.0", ElementName = "test")]
        public Form1()
        {
            InitializeComponent();
            Plants();
        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (listBox1.SelectedIndex != -1)
        //    {
        //        propertyGrid1.SelectedObject = listBox1.SelectedItem;
        //    }
        //}

        private void Plants()
        {
            var serializer = new XmlSerializer(typeof(PlantsBook));
            var plantsBookFromXml = new List<Plants>();

            using (var reader = new FileStream("test.xml", FileMode.Open))
            {
                plantsBookFromXml = ((PlantsBook)serializer.Deserialize(reader)).Items;
            }

            foreach (var plants in plantsBookFromXml)
            {
                listBox1.Items.Add(plants);
            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
