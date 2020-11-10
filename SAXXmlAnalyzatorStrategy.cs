using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Linq;

namespace Xml_Lab
{
    class SAXXmlAnalyzatorStrategy : IXmlAnalyzatorStrategy
    {
        private string _path;
        private XmlTextReader xmlTextReader;
        public SAXXmlAnalyzatorStrategy(string path)
        {
            _path = path;
            xmlTextReader = new XmlTextReader(_path);
        }

        public List<Member> Find(Member member)
        {
            List<Member> result = new List<Member>();           
            Member memberTemp;
            string cathedra = String.Empty;
            string cathedraID = String.Empty;
            string faculty = String.Empty;
            bool toAdd = false;
            while(xmlTextReader.Read())
            {
                if(xmlTextReader.Name == "Cathedra")
                {
                    while(xmlTextReader.MoveToNextAttribute())
                    {
                        if(xmlTextReader.Name == "CthdrName")
                        {
                            if(member.cathedra.cathedra == xmlTextReader.Value || member.cathedra.cathedra == String.Empty)
                            {
                                cathedra = xmlTextReader.Value;
                            }
                            else
                            {
                                xmlTextReader.Skip();
                            }
                        }
                        if(xmlTextReader.Name == "Cthdr_ID")
                        {
                            if(member.cathedra.cathedraID == xmlTextReader.Value || member.cathedra.cathedraID == String.Empty)
                            {
                                cathedraID = xmlTextReader.Value;
                            }
                            else
                            {
                                xmlTextReader.Skip();
                            }
                        }
                        if(xmlTextReader.Name == "FcltName")
                        {
                            if(member.cathedra.faculty == xmlTextReader.Value || member.cathedra.faculty == String.Empty)
                            {
                                faculty = xmlTextReader.Value;
                            }
                            else
                            {
                                xmlTextReader.Skip();
                            }
                        }
                    }
                }
                if(xmlTextReader.Name == "Member")
                {
                    toAdd = true;
                    memberTemp = new Member();
                    while(xmlTextReader.MoveToNextAttribute())
                    {
                        if(xmlTextReader.Name == "Name")
                        {
                            if(member.name == xmlTextReader.Value || member.name == String.Empty)
                            {
                                memberTemp.name = xmlTextReader.Value;
                            }
                            else
                            {
                                toAdd = false;
                                xmlTextReader.Skip();
                            }
                        }
                        if(xmlTextReader.Name == "TimeOfEntry")
                        {
                            if(member.timeOfEntry == xmlTextReader.Value || member.timeOfEntry == String.Empty)
                            {
                                memberTemp.timeOfEntry = xmlTextReader.Value;
                            }
                            else
                            {
                                toAdd = false;
                                xmlTextReader.Skip();
                            }
                        }
                        if(xmlTextReader.Name == "Sex")
                        {
                            if(member.sex == xmlTextReader.Value || member.sex == String.Empty)
                            {
                                memberTemp.sex = xmlTextReader.Value;
                            }
                            else
                            {
                                toAdd = false;
                                xmlTextReader.Skip();
                            }
                        }
                    }
                    if(toAdd)
                    {
                        memberTemp.cathedra.cathedra = cathedra;
                        memberTemp.cathedra.cathedraID = cathedraID;
                        memberTemp.cathedra.faculty = faculty;
                        result.Add(memberTemp);
                    }
                }
            }
            xmlTextReader.Close();
            return result;
        }
    }
}
