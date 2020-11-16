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
        private bool isButtonSearchClicked = false;
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
            List<Member> allMembers = new List<Member>();
            Member m = new Member(new DOMXmlAnalyzatorStrategy(path));
            allMembers = m.Find(m);
            foreach(Member member in allMembers)
            {
                if(!comboBoxCathedra.Items.Contains(member.cathedra.cathedra))
                {
                    comboBoxCathedra.Items.Add(member.cathedra.cathedra);
                }
                if(!comboBoxFaculty.Items.Contains(member.cathedra.faculty))
                {
                    comboBoxFaculty.Items.Add(member.cathedra.faculty);
                }
                if(!comboBoxID.Items.Contains(member.cathedra.cathedraID))
                {
                    comboBoxID.Items.Add(member.cathedra.cathedraID);
                }
                if(!comboBoxMember.Items.Contains(member.name))
                {
                    comboBoxMember.Items.Add(member.name);
                }
                if(!comboBoxSex.Items.Contains(member.sex))
                {
                    comboBoxSex.Items.Add(member.sex);
                }
                if(!comboBoxTImeOfEntry.Items.Contains(member.timeOfEntry))
                {
                    comboBoxTImeOfEntry.Items.Add(member.timeOfEntry);
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
            btnClear_Click(this, null);
            Member member = GetMember();
            members = member.Find(member);
            if(members != null)
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
            string xslFile = @"D:\C#\Xml_Lab\Xml_Lab\Transform.xsl";
            string htmlFile = @"D:\C#\Xml_Lab\Xml_Lab\Result.html";
            Transformator transformator = new Transformator(members, xslFile, htmlFile);
            transformator.Transform();
        }

        private void CheckToTransform()
        {
            if(!isButtonSearchClicked)
            {
                btnSearch_Click(this, null);
            }
        }

        private void InfoProg_Click(object sender, EventArgs e)
        {
            string info = "Роботу виконав: Пешко Сергій\n" +
                "Група: К-25\nСписок параметрів з'являється після обрання категорії";
            MessageBox.Show(info, "Довідка");
        }
    }
}
