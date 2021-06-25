﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring the path to the file
            string path = "myFile.txt";

            //Writing to the file
            using(StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("ABC");
                sw.WriteLine("DEF");
                sw.Close();
            }

            //Reading from this file
            if (File.Exists(path))
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            Console.Read();

        }
    }
}
