﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyDemo
{
    internal class FinallyStmt
    {
        static void Main(string[] args)
        {
            FileStream outStream = null;
            FileStream inStream = null;
            try
            {
                outStream = File.OpenWrite("DestinationFile.txt");
                inStream = File.OpenRead("BogusInputFile.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (outStream != null)
                {
                    outStream.Close();
                    Console.WriteLine("outStream closed.");
                }
                if (inStream != null)
                {
                    inStream.Close();
                    Console.WriteLine("inStream closed.");
                }
            }

        }
    }

}
