using ifmo.os.Lab2.Algorithms;
using System;
using System.Collections.Generic;
using System.Data;

namespace ifmo.os.Lab2
{
    class Program
    {
        private static readonly int OperationsAmount = 25;
        static void Main(string[] args)
        {
            var data = Generator.GenerateData(OperationsAmount);
            Emulator.Emulate(data, new FCFSAlgorithm());

            foreach (var operation in data)
            {
                operation.TimeLeaved = -1;
            }

            Emulator.Emulate(data, new SPNAlgorithm());
        }
    }
}
