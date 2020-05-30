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
            var queue = operations.Where( operation => 
                operation.TimeArrived <= timePassed && 
                operation.TimeLeaved == -1
            ).ToList();

            var minOperatingTime = int.MaxValue;
            var ind = 0;
            for (var i = 0; i < queue.Count; i++)
            {
                if (queue[i].TimeArrived >= timePassed && 
                    minOperatingTime > queue[i].OperatingTime)
                {
                    minOperatingTime = queue[i].OperatingTime;
                    ind = i;
                }
            }

            return operations.FindIndex(operation => 
                operation.TimeArrived == queue[ind].TimeArrived);
        }
    }
}
