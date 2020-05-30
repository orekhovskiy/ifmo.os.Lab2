using System;
using System.Collections.Generic;
using System.Text;

namespace ifmo.os.Lab2.Algorithms
{
    class FCFSAlgorithm : IAlgorithm
    {
        public int Pick(List<Operation> operations, int timePassed)
        {
            if (operations.Count == 0)
            {
                return -1;
            }
            for (var i = 0; i < operations.Count; i++)
            {
                if (operations[i].TimeArrived <= timePassed &&
                    operations[i].TimeLeaved == -1)
                {
                    return i;
                }
            }
            return -1;
        }
        public override string ToString()
        {
            return "FCFS";
        }
    }
    
}
