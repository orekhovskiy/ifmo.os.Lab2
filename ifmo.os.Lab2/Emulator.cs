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


            for (var i = 0; i < operations.Count; i++)
            {
                while (timePassed <= procReleaseAt + operations[i].OperatingTime)
                {

                    timePassed++;
                }
            }
        }
    }
}
