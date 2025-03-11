using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _280225csvreader;

namespace _280225csvreader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CvsManager cvs = new CvsManager();
            cvs.LoadCvs();
            Console.WriteLine(cvs.AverageValue());
        }
    }
}
