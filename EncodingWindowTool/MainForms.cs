using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyEncoding.Encoding.ClassDef;
using MyEncoding.Decoding.ClassDef;

namespace EncodingWindowTool
{
    public partial class MainForm : Form
    {
        FileInfo[] fis;
        Encoding encoding;
        Decoding decoding;
        Stream m_file_stream;
        bool IsUserInput = true;
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
            string[] Files = null;
            comboBox1.Items.Clear();
            try
            {
                Files = Directory.GetFiles("CodeFiles", "*.xml");
                fis = new FileInfo[Files.Length];
            }
            catch (Exception ex)
            {

            }
            int i = 0;
            foreach (var f in Files)
            {
                fis[i].FileName = Path.GetFileName(f);
                fis[i].FullFileName = f;
                i++;
            }
            foreach (var fi in fis)
            {
                comboBox1.Items.Add(fi.FileName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsUserInput)
            {
                IsUserInput = false;
                encoding.SetCode(textBox1.Text);
                textBox2.Text = encoding.GetEncoding();
                IsUserInput = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Space)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_file_stream != null)
                m_file_stream.Close();
            m_file_stream = File.OpenRead(fis[comboBox1.SelectedIndex].FullFileName);
            encoding = new Encoding(m_file_stream);
            decoding = new Decoding((FileStream)m_file_stream);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(IsUserInput)
            {
                IsUserInput = false;
                decoding.SetWord(textBox2.Text);
                textBox1.Text = decoding.GetDecoding();
                IsUserInput = true;
            }
        }
    }
}
