using System;
using System.Windows.Forms;
using System.Xml;

namespace XMLHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(stringsTxtBox.Text.Length > 0)
            {
                string xml = stringsTxtBox.Text;// 
                xml = xml.Replace("&", "").Replace("\n", "").Replace("&lt;", "").Replace("&#169;", "");
                XmlDocument xmlDoc = new XmlDocument();

                try
                {
                    xmlDoc.LoadXml(xml);
                }
                catch(Exception ex)
                {
                    if (ex.ToString().Contains("multiple root"))
                    {
                        MessageBox.Show("Root Node is Missing."+"\nAdd Root Node on XML String, Start and End like \n<root> Your XML Here</root>");
                    }
                }

                XmlNode root = xmlDoc.DocumentElement;

                if (root != null)
                {
                    string values = "";
                    for (int attribs = 0; attribs < root.ChildNodes.Count; attribs++)
                    {
                        values += root.ChildNodes[attribs].InnerText + Environment.NewLine;
                    }

                    valuesTxtBox.Text = values;
                }
            }
            else
            {
                MessageBox.Show("Please enter XML String first, to extract Text.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stringsTxtBox.Text = "";
            valuesTxtBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] itemList = valuesTxtBox.Text.Replace("\r", "").Split('\n');

            if (stringsTxtBox.Text.Length > 0 && valuesTxtBox.Text.Length > 0)
            {
                string xml = stringsTxtBox.Text;

                xml = xml.Replace("&", "").Replace("\n", "").Replace("&lt;", "").Replace("&#169;", "169;");
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);
                XmlNode root = xmlDoc.DocumentElement;

                if (root != null)
                {
                    for (int i = 0; i < itemList.Length; i++)
                    {
                        try
                        {

                            root.ChildNodes[i].InnerText = itemList[i];
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }

                    valuesTxtBox.Text = root.OuterXml;
                }
            }
            else if (valuesTxtBox.Text.Length > 0)
            {
                string[] nodeList = valuesTxtBox.Text.Replace("\r", "").Split('\n');

                XmlDocument xmlDoc = new XmlDocument();
                XmlNode root = xmlDoc.CreateNode(XmlNodeType.Element, "root", ""); ;

                for (int i=0; i < nodeList.Length; i++)
                {
                    XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, "node", "");
                    node.InnerText = nodeList[i];
                    root.AppendChild(node);
                }
                
                if (root != null)
                {
                    for (int i = 0; i < itemList.Length; i++)
                    {
                        try
                        {

                            root.ChildNodes[i].InnerText = itemList[i];
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }

                    valuesTxtBox.Text = root.OuterXml;
                }
            }
            else
            {
                MessageBox.Show("Please enter Text to create XML String.");
            }
        }
    }
}
