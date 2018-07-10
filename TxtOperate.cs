using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtReadWrite
{
    public class TxtOperate
    {
        /// <summary>
        /// txt读取
        /// </summary>
        public static List<string> TxtRead()
        {
            var strList = new List<string>();
            try
            {
                // 创建一个 StreamReader 的实例来读取文件 
                // using 语句也能关闭 StreamReader
                using (StreamReader sr = new StreamReader("loginInfo.txt"))
                {
                    string line;

                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        strList.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                // 向用户显示出错消息
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return strList;
        }
        /// <summary>
        /// txt写入
        /// </summary>
        public static bool TxtWrite(List<string> strList)
        {
            bool isSuccess = false;
            try
            {
                using (StreamWriter sw = new StreamWriter("loginInfo.txt"))
                {
                    foreach (string s in strList)
                    {
                        sw.WriteLine(s);

                    }
                    isSuccess = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isSuccess;

            // 从文件中读取并显示每行
            //string line = "";
            //using (StreamReader sr = new StreamReader("loginInfo.txt"))
            //{
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //Console.ReadKey();
        }
    }
}
