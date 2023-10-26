using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"C:\temp\dados_iniciais.txt";
            string targetPath = @"C:\temp\dados_finais.txt";

            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath)) {

                for (int i = 1; i <= lines.Length - 1; i++) {
                    sw.Write(lines[i]);
                    sw.WriteLine($"; {i}; ");
                }
            }    
        }
    }
}