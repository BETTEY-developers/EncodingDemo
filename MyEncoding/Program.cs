using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace MyEncoding
{
    
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {/*
           if(args.Length == 1)
           {
                if(args[0].StartsWith("File:"))
                {
                    Encoding.ClassDef.Encoding encoding = new Encoding.ClassDef.Encoding(new StreamReader(args[0].Split(':')[1]));
                    encoding.XmlAddress = "DeflautCodes.xml";
                    Console.WriteLine(encoding.GetEncoding());
                }
                
           }
           else
           {
                var True = true;
                var TRUE = True;
                var TRUEBOOLEAN = TRUE;
                while(TRUEBOOLEAN)
                {
                    Console.Write(">>> ");
                    string c = Console.ReadLine();
                    Encoding.ClassDef.Encoding
                    encoding
                    =
                    new
                    Encoding
                    .
                    ClassDef
                    .
                    Encoding
                    (
                        c
                    )
                    ;
                    encoding
                    .
                    XmlAddress
                    =
                    "DeflautCodes.xml"
                    ;
                    Console
                    .
                    WriteLine(
                    encoding
                    .
                    GetEncoding()
                    )
                    ;
                }
           }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
