using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // using input output
namespace FileNotFoundException
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string filename = "norina.nor";
            try
            {
                File.OpenRead(filename);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
    