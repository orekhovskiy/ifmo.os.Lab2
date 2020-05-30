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
            var maxQueueLength = 0;

            // Emulation
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
                maxQueueLength = GetMaxQueueLength(operations, 
                    timePassed, maxQueueLength);
                timePassed++;
            }
            // Report purpose
            Log(operations, picker, maxQueueLength);
        }

        private static void Log(List<Operation> operations, IAlgorithm picker, int maxQueueLength)
        {
            Console.WriteLine($"Picking algorithm: {picker}");
            Console.WriteLine($"Maximum length of the queue was {maxQueueLength}");
            Console.WriteLine("Time arrived\tOperating time\tWaiting time");
            foreach (var operation in operations)
            {
                var waitingTime = operation.TimeLeaved - 
                    operation.TimeArrived - operation.OperatingTime;
                Console.WriteLine($"{operation.TimeArrived}\t\t{operation.OperatingTime}\t\t{waitingTime}");
            }
            Console.WriteLine();

            foreach (var operation in operations)
            {
                var waitingTime = operation.TimeLeaved -
                    operation.TimeArrived - operation.OperatingTime;
                Console.WriteLine($"{waitingTime}");
            }
            Console.WriteLine();
        }

        private static int GetMaxQueueLength(List<Operation> operations, int timePassed, int maxQueueLength)
        {
            var curQueueLength = operations.Where(o =>
                    o.TimeArrived <= timePassed &&
                    o.TimeLeaved == -1).Count();
            return Math.Max(curQueueLength, maxQueueLength);
        }
    }
}
