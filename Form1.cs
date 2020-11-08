using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Dynamic;
using System.Xml.Xsl;

namespace Xml_Lab
{
    public partial class Form1 : Form
    {
        private string path = @"D:\C#\Xml_Lab\Xml_Lab\ScientificSociety.xml";
        bool isButtonSearchClicked = false;
        private List<Member> members;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ParseDocument();
            comboBoxFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCathedra.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMember.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTImeOfEntry.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void ParseDocument()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNodeList cathedras = root.SelectNodes("Cathedra");
            foreach (XmlNode cathedra in cathedras)
            {
                XmlNodeList members = cathedra.SelectNodes("Member");
                comboBoxCathedra.Items.Add(cathedra.SelectSingleNode("@CthdrName").Value);
                comboBoxID.Items.Add(cathedra.SelectSingleNode("@Cthdr_ID").Value);
                string fcltName = cathedra.SelectSingleNode("@FcltName").Value;
                if (!comboBoxFaculty.Items.Contains(fcltName))
                {
                    comboBoxFaculty.Items.Add(fcltName);
                }
                foreach (XmlNode member in members)
                {
                    comboBoxMember.Items.Add(member.SelectSingleNode("@Name").Value);
                    string sex = member.SelectSingleNode("@Sex").Value;
                    if (!comboBoxSex.Items.Contains(sex))
                    {
                        comboBoxSex.Items.Add(sex);
                    }
                    string timeOfEntry = member.SelectSingleNode("@TimeOfEntry").Value;
                    if (!comboBoxTImeOfEntry.Items.Contains(timeOfEntry))
                    {
                        comboBoxTImeOfEntry.Items.Add(timeOfEntry);
                    }
                }
            }

        }

        private void CustomizeComboBox(CheckBox checkBox, ComboBox comboBox)
        {
            if(checkBox.Checked)
            {
                comboBox.Visible = true;
                comboBox.Text = null;
            }
            else
            {
                comboBox.Visible = false;
            }
        }

        private void cbFaculty_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(cbFaculty, comboBoxFaculty);
        }

        private void cbCathedra_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(cbCathedra, comboBoxCathedra);
        }

        private void cbMember_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(cbMember, comboBoxMember);
        }

        private void cbID_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(cbID, comboBoxID);
        }

        private void cbSex_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(cbSex, comboBoxSex);
        }

        private void cbTimeOfEntry_Click(object sender, EventArgs e)
        {
            CustomizeComboBox(cbTimeOfEntry, comboBoxTImeOfEntry);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            isButtonSearchClicked = true;
            Member member = GetMember();
            members = member.Find(member);
            PrintMembers(members);
        }

        /// <summary>
        /// Reads Member from ComboBoxes
        /// </summary>
        /// <returns></returns>
        private Member GetMember()
        {
            Member member = new Member();
            if (radioButtonDOM.Checked)
                member = new Member(new DOMXmlAnalyzatorStrategy(path));
            if (radioButtonSAX.Checked)
                member = new Member(new SAXXmlAnalyzatorStrategy(path));
            if (radioButtonLINQ.Checked)
                member = new Member(new LINQXmlAnalyzatorStrategy(path));
            member.name = cbMember.Checked ? comboBoxMember.Text : String.Empty;
            member.cathedra.faculty = cbFaculty.Checked ? comboBoxFaculty.Text : String.Empty;
            member.cathedra.cathedraID = cbID.Checked ? comboBoxID.Text : String.Empty;
            member.cathedra.cathedra = cbCathedra.Checked ? comboBoxCathedra.Text : String.Empty;
            member.sex = cbSex.Checked ? comboBoxSex.Text : String.Empty;
            member.timeOfEntry = cbTimeOfEntry.Checked ? comboBoxTImeOfEntry.Text : String.Empty;
            return member;
        }

        /// <summary>
        /// Prints list of members to the RichTExtBox
        /// </summary>
        /// <param name="members"></param>
        private void PrintMembers(List<Member> members)
        {
            string output = String.Empty;
            foreach (Member member in members)
            {
                output = String.Empty;
                output += "Ім'я: " + member.name + "\r\n";
                output += "Cathedra: " + member.cathedra.cathedra + "\r\n";
                output += "Faculty: " + member.cathedra.faculty + "\r\n";
                output += "Cathedra ID: " + member.cathedra.cathedraID + "\r\n";
                output += "Sex: " + member.sex + "\r\n";
                output += "Time of entry: " + member.timeOfEntry + "\r\n";
                output += "===============================\r\n";
                rtbResult.Text += output;
            }
            if (output == String.Empty)
            {
                rtbResult.Text += "No matches found!!!\r\n";
                rtbResult.Text += "===============================\r\n";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dr = MessageBox.Show("Ви дійсно хочете вийти?", "Підтвердження про вихід", MessageBoxButtons.YesNo);
            e.Cancel = (dr == DialogResult.Yes ? false : true);
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            CheckToTransform();
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(@"D:\C#\Xml_Lab\Xml_Lab\Transform.xsl");
            CreateXmlForTransforming();
            string input = @"D:\C#\Xml_Lab\Xml_Lab\Temp.xml";
            string result = @"D:\C#\Xml_Lab\Xml_Lab\Result.html";
            xslt.Transform(input, result);
        }

        private void CheckToTransform()
        {
            if(!isButtonSearchClicked)
            {
                btnSearch_Click(this, null);
            }
        }
        private void CreateXmlForTransforming()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));
            var root = xmlDoc.CreateElement("ScientificSociety");
            xmlDoc.AppendChild(root);
            foreach(var m in members)
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
                xmlDoc.Save(@"D:\C#\Xml_Lab\Xml_Lab\Temp.xml");
        }
    }
}
