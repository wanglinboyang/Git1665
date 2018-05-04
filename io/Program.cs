using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("D:\\晚自习.txt",FileMode.Append);
            //2.创建写入器
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            //3.真正写入
            sw.WriteLine("我真的是无语了！");
            sw.Close();
            fs.Close();
            Console.WriteLine("成功！");
            Reache();
        }
        private static void Reache() 
        {
            FileStream fs = new FileStream("D:\\晚自习.txt",FileMode.Open);
            //02.创建读取器
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("gbk"));
            //03.读取操作
            string words = sr.ReadToEnd();
            Console.WriteLine(words);
            sr.Close();
            fs.Close();
            Console.WriteLine("读取成功！");
            Console.ReadKey();
        }
    }
}
