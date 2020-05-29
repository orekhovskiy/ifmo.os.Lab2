using System;
using System.Collections.Generic;
using System.Text;

namespace ifmo.os.Lab2
{
    public static class Generator
    {
        private static readonly Random Rand = new Random();

        public static List<Operation> GenerateData(int operationsAmount)
        {
            var data = new List<Operation>();
            var timeArrived = 0;
            for (var i = 0; i < operationsAmount; i++)
            {
                data.Add(new Operation(timeArrived, GetOperatingTime()));
                timeArrived += GetNextOperationIn();
            }
            return data;
        }

        private static int GetNextOperationIn()
        {
            var between = 5;
            var accuracy = 3;
            return Rand.Next(between - accuracy, between + accuracy + 1);
        }

        private static int GetOperatingTime()
        {
            var from = 3;
            var to = 10;
            return Rand.Next(from, to + 1);
        }
    }
}
