using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyEncoding.Encoding.MyXmlClassDef
{
    /// <summary>
    /// 提供对<see cref="XmlElement"/>的公共访问
    /// </summary>
    public class M_XmlElement : XmlElement
    {
        public M_XmlElement(string Name, XmlDocument xd) : base("", Name, "", xd) { }
    }

    
}
