using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEncoding
{
    public partial class MainForm : Form
    {
        FileInfo[] fis;
        Encoding.ClassDef.Encoding encoding;
        StreamReader m_stream_reader;
        struct FileInfo
        {
            public string FileName;
            public string FullFileName;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void 工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCharcodeToolWindow ccctw = new CreateCharcodeToolWindow();
            ccctw.ShowDialog();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] Files = Directory.GetFiles("CodeFiles", "*.xml");
            fis = new FileInfo[Files.Length];
            int i = 0;
            foreach(var f in Files)
            {
                fis[i].FileName = Path.GetFileName(f);
                fis[i].FullFileName = f;
                i++;
            }
            foreach(var fi in fis)
            {
                comboBox1.Items.Add(fi.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData != Keys.Space)
            {
                textBox2.Text=encoding.GetEncoding();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(m_stream_reader != null)
                m_stream_reader.Close();
            m_stream_reader = new StreamReader(new FileStream(fis[comboBox1.SelectedIndex].FullFileName, FileMode.Open));
            encoding = new Encoding.ClassDef.Encoding(m_stream_reader);
        }
    }
}
