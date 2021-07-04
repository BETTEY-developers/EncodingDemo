using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using MyEncoding.Encoding.ClassDef;

namespace EncodingWindowTool
{
    public partial class CreateCharcodeToolWindow : Form
    {
        public CreateCharcodeToolWindow()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(FName.Text != "")
            {
                {
                    if (true)
                    {
                        Dictionary<string, string> CT = new Dictionary<string, string>(100000);
                        string[] K = Codes.Text.Split(' ');
                        string[] V = Texts.Text.Split(' ');
                        int i = 0;
                        foreach(var s in K)
                        {
                            CT.Add(s, V[i]);
                            i++;
                        }
                        i = 0;
                        Directory.CreateDirectory("CodeFiles");
                        XmlWriter xw = XmlWriter.Create("CodeFiles\\" + FName.Text + ".xml");
                        xw.WriteStartElement("note");
                        foreach(var v in K)
                        {
                            
                            xw.WriteStartElement("list");
                            xw.WriteElementString("Key", v);
                            xw.WriteElementString("Value", V[i]);
                            xw.WriteEndElement();
                            i++;
                        }
                        xw.WriteEndElement();
                        xw.Close();
                        xw.Dispose();
                    }
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
