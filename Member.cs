using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace Xml_Lab
{
    public class Cathedra
    {
        public string cathedra = String.Empty;
        public string cathedraID = String.Empty;
        public string faculty = String.Empty;
    }
    public class Member
    {
        public string name = String.Empty;
        public string timeOfEntry = String.Empty;
        public string sex = String.Empty;
        public Cathedra cathedra = new Cathedra();
        public IXmlAnalyzatorStrategy Analyzator { get; private set; }
        public Member(IXmlAnalyzatorStrategy analyzator)
        {
            Analyzator = analyzator;
        }
        public Member()
        { }
        public bool Compare(Member member)
        {
            if (!name.Contains(member.name)) { return false; }
            if (!timeOfEntry.Contains(member.timeOfEntry)) { return false; }
            if (!sex.Contains(member.sex)) { return false; }
            if (!cathedra.cathedra.Contains(member.cathedra.cathedra)) { return false; }
            if (!cathedra.faculty.Contains(member.cathedra.faculty)) { return false; }
            if (!cathedra.cathedraID.Contains(member.cathedra.cathedraID)) { return false; }
            return true;
        }
        public List<Member> Find(Member member)
        {
            try 
            {
                return Analyzator.Find(member);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Виберіть спосіб пошуку(DOM, SAX, LINQ to Xml)");
                return new List<Member>();
            }
        }
    }
}
