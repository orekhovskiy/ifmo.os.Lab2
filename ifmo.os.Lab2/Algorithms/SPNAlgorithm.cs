using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ifmo.os.Lab2.Algorithms
{
    class SPNAlgorithm : IAlgorithm
    {
        public int Pick(List<Operation> operations, int timePassed)
        {
            var queue = operations.Where(
                operation => operation.TimeArrived >= timePassed && 
                ).ToList();
            var minOperatingTime = int.MaxValue;
            var ind = 0;
            for (var i = 0; i < operations.Count; i++)
            {
                if (operations[i].TimeArrived >= timePassed && 
                    minOperatingTime > operations[i].OperatingTime)
                {
                    minOperatingTime = operations[i].OperatingTime;
                    ind = i;
                }
            }
            return ind;
        }
    }
}
