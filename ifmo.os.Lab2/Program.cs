using ifmo.os.Lab2.Algorithms;
using System;
using System.Collections.Generic;
using System.Data;

namespace ifmo.os.Lab2
{
    class Program
    {
        private static readonly int OperationsAmount = 20;
        static void Main(string[] args)
        {
            var data = Generator.GenerateData(OperationsAmount);
            //Emulator.Emulate(data, new FCFSAlgorithm());
            //Emulator.Emulate(data, new SPNAlgorithm());
        }
    }
}
