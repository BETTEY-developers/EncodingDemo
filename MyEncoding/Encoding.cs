namespace MyEncoding
{
    namespace Encoding.InterFaceDef
    {
        public interface IEncodingDecodingFun
        {
            string GetEncoding();

            string CodeString { get; }
            string[] CodeS { get; }
        }

        public interface IEncodingDecodingFun<T, VT> : IEncodingDecodingFun
        {
            VT GetValueTable();
            IEncodingDecodingFun This { get; }
            VT ThcodeTable { get; }
        }
    }
    namespace Encoding.ClassDef
    {
        using MyEncoding.Encoding.InterFaceDef;
        using System;
        using System.Collections.Generic;
        using System.IO;
        using System.Xml;

        public class TableFuns
        {
            Stream m_stream;
            XmlDocument xml = new XmlDocument();
            Dictionary<string, string> Pairs = new Dictionary<string, string>(0xFFF7);

            public Dictionary<string, string> Pairs1 { get => Pairs; set => Pairs = value; }

            public TableFuns(Stream stream)
            {
                m_stream = stream;
                m_stream.Position = 0;
                xml.Load(m_stream);
            }

            internal void AddWords()
            {
                Pairs.Clear();
                XmlElement StElement = xml.DocumentElement;
                string Key = "";
                string Value = "";
                foreach (XmlElement ChildElement in StElement.ChildNodes)
                {
                    foreach (XmlElement ChildElements in ChildElement.ChildNodes)
                    {
                        if (ChildElements.LocalName == "Key")
                        {
                            Key = ChildElements.InnerText;
                        }
                        else if (ChildElements.LocalName == "Value")
                        {
                            Value = ChildElements.InnerText;
                        }
                        else
                        {
                            throw new FormatException("XmlError: List childnode only two childnode!");
                        }
                    }
                    Pairs1.Add(Key, Value);
                }
                
            }

            public Dictionary<string, string> GetWords()
            {
                return Pairs1;
            }

            internal TableFuns GetTableValue()
            {
                return this;
            }
        }

        public class CRD2Encoding : Encoding
        {
            //
        }

        public class Encoding : IEncodingDecodingFun<Encoding, TableFuns>, IEncodingDecodingFun
        {
            TableFuns table;

            private string xmlAddress;
            string[] m_Codes;
            string m_Code;
            int m_index;
            bool m_bool = false;
            private Stream m_stream;
            internal string m_bodyname;

            /// <summary>
            /// 获取此实例的副本
            /// </summary>
            IEncodingDecodingFun IEncodingDecodingFun<Encoding, TableFuns>.This
            {
                get
                {
                    IEncodingDecodingFun encoding = this;
                    return encoding;
                }
            }

            /// <summary>
            /// 获取此实例的表数据
            /// </summary>
            TableFuns IEncodingDecodingFun<Encoding, TableFuns>.ThcodeTable
            {
                get
                {
                    return table.GetTableValue();
                }
            }

            /// <summary>
            /// 获取此实例的代码集
            /// </summary>
            string[] IEncodingDecodingFun.CodeS
            {
                get
                {
                    return Codes;
                }
            }

            string IEncodingDecodingFun.CodeString
            {
                get
                {
                    if (Code != null)
                    {
                        return Code;
                    }
                    return "";
                }
            }
            internal TableFuns Table { get => table; set => table = value; }
            public string XmlAddress { get => xmlAddress; set => xmlAddress = value; }
            public string[] Codes { get => m_Codes; set => m_Codes = value; }
            public string Code { get => m_Code; set => m_Code = value; }
            public int Index { get => m_index; set => m_index = value; }
            public Stream XmlFileStream { get => m_stream; set => m_stream = value; }
            public string BodyName { get => m_bodyname; set => m_bodyname = value; }

            public static readonly Encoding CRD2 = new CRD2Encoding();

            /// <summary>
            /// 初始化<see cref="Encoding"/>构造函数
            /// </summary>
            public Encoding() {
                if(!m_bool)
                    Codes = new string[0xFFF7];
                m_bool = !m_bool;
            }

            /// <summary>
            /// 初始化<see cref="Encoding"/>构造函数并设置表流
            /// </summary>
            /// <param name="reader"></param>
            public Encoding(Stream reader) : this()
            {
                m_stream = reader;
                Table = new TableFuns(m_stream);
                Table.AddWords();
            }

            /// <summary>
            /// 设置代码集
            /// </summary>
            /// <param name="Code">代码的原字符串</param>
            public void SetCode(string Code)
            {
                Codes = Code.Split(' ');
            }

            /// <summary>
            /// （函数式编程）获取表数据
            /// </summary>
            /// <returns>此实例的<see cref="TableFuns"/>表数据副本</returns>
            TableFuns IEncodingDecodingFun<Encoding, TableFuns>.GetValueTable()
            {
                return table;
            }

            string IEncodingDecodingFun.GetEncoding()
            {
                string Result = "";

                var d = table.GetWords();

                foreach (string code in Codes)
                {
                    if (code == null)
                        break;
                    foreach (string k in d.Keys)
                    {
                        if (!table.GetWords().ContainsKey(code))
                        {
                            Result += ".";
                            break;
                        }
                        if (code == k)
                        {
                            Result += d[k];
                            break;
                        }
                    }
                }
                return Result;
            }

            /// <summary>
            /// 获取已解析的字符
            /// </summary>
            /// <returns>解析后的<see cref="string"/>字符</returns>
            public string GetEncoding()
            {
                IEncodingDecodingFun ief = this;
                return ief.GetEncoding();
            }
        }
    }
}