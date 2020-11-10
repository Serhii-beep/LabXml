using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Xsl;

namespace Xml_Lab
{
    class Transformator
    {
        private List<Member> members;
        private string rootToTempXml = @"D:\C#\Xml_Lab\Xml_Lab\Temp.xml";
        private string rootToXsl;
        private string rootToOutputFile;
        public Transformator(List<Member> _members, string _rootToXsl, string _rootToOutputFile)
        {
            members = _members;
            rootToOutputFile = _rootToOutputFile;
            rootToXsl = _rootToXsl;
        }
        public void Transform()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(rootToXsl);
            CreateXmlForTransforming();
            string input = rootToTempXml;
            string result = rootToOutputFile;
            xslt.Transform(input, result);
        }
        private void CreateXmlForTransforming()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));
            var root = xmlDoc.CreateElement("ScientificSociety");
            xmlDoc.AppendChild(root);
            if (members != null)
            {
                foreach (var m in members)
                {
                    XmlElement member = xmlDoc.CreateElement("Member");
                    XmlAttribute name = xmlDoc.CreateAttribute("Name");
                    XmlAttribute timeOfEntry = xmlDoc.CreateAttribute("TimeOfEntry");
                    XmlAttribute sex = xmlDoc.CreateAttribute("Sex");
                    XmlAttribute cthdrName = xmlDoc.CreateAttribute("CthdrName");
                    XmlAttribute cthdrID = xmlDoc.CreateAttribute("Cthdr_ID");
                    XmlAttribute fcltName = xmlDoc.CreateAttribute("FcltName");
                    name.Value = m.name;
                    timeOfEntry.Value = m.timeOfEntry;
                    sex.Value = m.sex;
                    cthdrName.Value = m.cathedra.cathedra;
                    cthdrID.Value = m.cathedra.cathedraID;
                    fcltName.Value = m.cathedra.faculty;
                    member.Attributes.Append(name);
                    member.Attributes.Append(timeOfEntry);
                    member.Attributes.Append(sex);
                    member.Attributes.Append(cthdrName);
                    member.Attributes.Append(cthdrID);
                    member.Attributes.Append(fcltName);
                    root.AppendChild(member);
                }
            }
            xmlDoc.Save(rootToTempXml);
        }
    }
}
