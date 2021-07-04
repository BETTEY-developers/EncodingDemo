using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEncoding
{
    namespace Decoding.InterFaceDef
    {
        public interface IDecoding
        {
            string Word { get; set; }
            FileStream XmlRead { get; set; }

            string GetDecoding();
        }
    }
    namespace Decoding.ClassDef
    {
        public class Decoding : InterFaceDef.IDecoding
        {
            Encoding.ClassDef.TableFuns table;
            string m_word;
            FileStream m_xmlStream;


            public string Word { get => m_word; set => m_word = value; }
            public FileStream XmlRead { get => m_xmlStream; set => m_xmlStream = value; }

            public Decoding(FileStream Xml)
            {
                XmlRead = Xml;
                table = new Encoding.ClassDef.TableFuns(XmlRead);
            }

            public void SetWord(string word)
            {
                m_word = word;
            }

            public string GetDecoding()
            {
                string result = "";

                table.AddWords();
                char[] CharSub = m_word.ToCharArray();
                var WCDict = table.GetWords();
                foreach (var v in WCDict)
                {
                    foreach (var chars in CharSub)
                    {
                        if(chars == '\n')
                        {
                            break;
                        }
                        if (chars == v.Value[0])
                        {
                            result += v.Key;
                            result += " ";
                            break;
                        }
                        else if(!WCDict.ContainsValue(chars.ToString()))
                        {
                            for(int i = 0; i < v.Key.Length; i++)
                            {
                                result += ".";
                            }
                            result += " ";
                        }
                    }
                }
                
                return result.Trim();
            }
        }
    }
}
