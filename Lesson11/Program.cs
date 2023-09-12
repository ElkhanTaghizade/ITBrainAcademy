using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream_Writer_Reader
{
    internal class Program
    {
        class FileWrite
        {
            public void WriteData()
            {
                FileStream fs = new FileStream("C:\\Users\\ASUS\\Documents\\TextFile1.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Enter name, surname:");
                string data=Console.ReadLine();
                sw.WriteLine(data);
                sw.WriteLine("Added:"+DateTime.Now);
                sw.Flush();
                sw.Close();
                fs.Close();
                string data1=data+" : "+DateTime.Now;
                Console.WriteLine(data1);
            }

        }
        class FileRead
        {
            public void ReadData()
            {
                FileStream fs = new FileStream("C:\\Users\\ASUS\\Documents\\TextFile1.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr= new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string data=sr.ReadLine();
                while(data!=null)
                {
                    Console.WriteLine(data);
                    data = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
        }
        static void Main(string[] args)
        {
            FileWrite fw = new FileWrite();
            fw.WriteData();
            FileRead fileRead = new FileRead();
            fileRead.ReadData();
        }
    }
    
}
