using ifmo.os.Lab2.Algorithms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ifmo.os.Lab2
{
    public static class Emulator
    {
        public static void Emulate(List<Operation> operations, IAlgorithm picker)
        {
            // Pseudo proc preparation
            var procReleaseAt = 0;
            var timePassed = 0;

            while (operations.Where(o => o.TimeLeaved == -1).Count() > 0)
            {
                if (timePassed >= procReleaseAt)
                {
                    var ind = picker.Pick(operations, timePassed);
                    if (ind != -1)
                    {
                        procReleaseAt = timePassed + operations[ind].OperatingTime;
                        operations[ind].TimeLeaved = procReleaseAt;
                    }
                }
                timePassed++;
            }
            Log(operations, picker);
        }

        private static void Log(List<Operation> operations, IAlgorithm picker)
        {
            Console.WriteLine(picker);
            foreach (var operation in operations)
            {
                Console.WriteLine($"\t{operation.TimeArrived}\t{operation.TimeLeaved}");
            }
            Console.WriteLine();
        }
    }
}
