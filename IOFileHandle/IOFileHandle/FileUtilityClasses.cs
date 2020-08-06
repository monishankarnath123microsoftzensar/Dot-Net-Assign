using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOFileHandle
{
    class FileUtilityClasses
    {
        static void Main()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(@"E:\Dotnettraining\DotnetConsoleApps\file.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("We have created file.txt");
                sw.WriteLine("----------Moni-----------");
                sw.WriteLine("Try catch example");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
                Console.WriteLine("Data Written");
            }
            
        }
    }
}
