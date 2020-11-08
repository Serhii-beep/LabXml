using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace Xml_Lab
{
    class LINQXmlAnalyzatorStrategy : IXmlAnalyzatorStrategy
    {
        string _path;
        XDocument doc;
        public LINQXmlAnalyzatorStrategy(string path)
        {
            _path = path;
            doc = new XDocument();
            doc = XDocument.Load(_path);
        }
        public List<Member> Find(Member member)
        {
            List<Member> result = new List<Member>();
            List<XElement> XResult =
                (
                    from value in doc.Descendants("Member")
                    where
                    (
                        (member.cathedra.cathedra == String.Empty || member.cathedra.cathedra == value.Parent.Attribute("CthdrName").Value) &&
                        (member.cathedra.cathedraID == String.Empty || member.cathedra.cathedraID == value.Parent.Attribute("Cthdr_ID").Value) &&
                        (member.cathedra.faculty == String.Empty || member.cathedra.faculty == value.Parent.Attribute("FcltName").Value) &&
                        (member.name == String.Empty || member.name == value.Attribute("Name").Value) &&
                        (member.timeOfEntry == String.Empty || member.timeOfEntry == value.Attribute("TimeOfEntry").Value) &&
                        (member.sex == String.Empty || member.sex == value.Attribute("Sex").Value)
                    )
                    select value
                ).ToList();
            foreach(XElement element in XResult)
            {
                Member memberTemp = new Member();
                memberTemp.cathedra.cathedra = element.Parent.Attribute("CthdrName").Value;
                memberTemp.cathedra.cathedraID = element.Parent.Attribute("Cthdr_ID").Value;
                memberTemp.cathedra.faculty = element.Parent.Attribute("FcltName").Value;
                memberTemp.name = element.Attribute("Name").Value;
                memberTemp.timeOfEntry = element.Attribute("TimeOfEntry").Value;
                memberTemp.sex = element.Attribute("Sex").Value;
                result.Add(memberTemp);
            }
            return result;
        }
    }
}
