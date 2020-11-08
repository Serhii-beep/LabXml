using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Linq;
using System.IO;

namespace Xml_Lab
{
    class DOMXmlAnalyzatorStrategy : IXmlAnalyzatorStrategy
    {
        private string _path;
        XmlDocument doc;
        public DOMXmlAnalyzatorStrategy(string path)
        {
            _path = path;
            doc = new XmlDocument();
            doc.Load(_path);
        }
        public List<Member> Find(Member member)
        {
            List<Member> result = new List<Member>();
            List<string> cathedra_attr = new List<string>();
            List<string> member_attr = new List<string>();
            string xPath = "//Cathedra";
            if (member.cathedra.cathedra != String.Empty) cathedra_attr.Add($"@CthdrName=\"{member.cathedra.cathedra}\"");
            if (member.cathedra.cathedraID != String.Empty) cathedra_attr.Add($"@Cthdr_ID=\"{member.cathedra.cathedraID}\"");
            if (member.cathedra.faculty != String.Empty) cathedra_attr.Add($"@FcltName=\"{member.cathedra.faculty}\"");
            for(int i = 0; i < cathedra_attr.Count; ++i)
            {
                if(i == 0)
                {
                    xPath += "[" + cathedra_attr[i];
                }
                else
                {
                    xPath += " and " + cathedra_attr[i];
                }
                if(i == cathedra_attr.Count - 1)
                {
                    xPath += "]";
                }
            }
            xPath += "//Member";
            if (member.name != String.Empty) member_attr.Add($"@Name=\"{member.name}\"");
            if (member.timeOfEntry != String.Empty) member_attr.Add($"@TimeOfEntry=\"{member.timeOfEntry}\"");
            if (member.sex != String.Empty) member_attr.Add($"@Sex=\"{member.sex}\"");
            for(int i = 0; i < member_attr.Count; ++i)
            {
                if (i == 0)
                {
                    xPath += "[" + member_attr[i];
                }
                else
                {
                    xPath += " and " + member_attr[i];
                }
                if (i == member_attr.Count - 1)
                {
                    xPath += "]";
                }
            }
            XmlNodeList members = doc.SelectNodes(xPath);
            foreach (XmlNode memberNode in members)
            {
                Member memberTemp = new Member();
                memberTemp.cathedra.cathedra = memberNode.ParentNode.Attributes.GetNamedItem("CthdrName").Value;
                memberTemp.cathedra.cathedraID = memberNode.ParentNode.Attributes.GetNamedItem("Cthdr_ID").Value;
                memberTemp.cathedra.faculty = memberNode.ParentNode.Attributes.GetNamedItem("FcltName").Value;
                memberTemp.name = memberNode.Attributes.GetNamedItem("Name").Value;
                memberTemp.timeOfEntry = memberNode.Attributes.GetNamedItem("TimeOfEntry").Value;
                memberTemp.sex = memberNode.Attributes.GetNamedItem("Sex").Value;
                result.Add(memberTemp);
            }          
            return result;
        }
    }
}
