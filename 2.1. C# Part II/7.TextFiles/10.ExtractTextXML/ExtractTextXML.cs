using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


class ExtractTextXML
{
    static void Main()
    {
        string url = "File.xml";

        XmlDocument doc = new System.Xml.XmlDocument();
        doc.Load(url);
        XmlElement docElement = doc.DocumentElement;

        foreach (XmlNode childNode in docElement.ChildNodes)
        {
            Console.WriteLine(childNode.InnerText);
        }
        
    }
}

