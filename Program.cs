using System;
using System.IO;

namespace SelfLearning_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            string fpath = @"C:\Users\11033259\Desktop\fresher_training\Student_data.txt";
            StreamReader sr = new StreamReader(fpath);
            string fileContent = sr.ReadToEnd();
            Console.WriteLine(fileContent);
            sr.Close();
        }
    }
}
