using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("XMLFile1.xml");
            XmlNode root = doc.DocumentElement;
            //foreach (XmlNode item in root.ChildNodes )
            //{
            //    //一个item就是一个book节点
            //    foreach (XmlNode child in item.ChildNodes)
            //    {
            //        if (child.Name == "bookName") 
            //        {
            //            Console.WriteLine("图书名:"+child.InnerText);
            //        }
            //        else if (child.Name == "bookPrice") 
            //        {
            //            Console.WriteLine("价格:"+child.InnerText);
            //        }
            //    }
               // Console.WriteLine("==================end===================");
            //}
            foreach (XmlNode item in root.ChildNodes)
            {
                Console.WriteLine("编号："+item.Attributes["id"].Value.ToString());
                Console.WriteLine("图书名："+item["bookName"].InnerText);
                Console.WriteLine("价格："+item["bookPrice"].InnerText);
                Console.WriteLine("====================End==================");
            }
            Console.ReadKey();
        }
    }
}
