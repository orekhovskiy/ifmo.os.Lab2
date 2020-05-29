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
                throw new Exception("Operations list is empty.");
            }
            for (var i = 0; i < operations.Count; i++)
            {
                if (operations[i].TimeArrived >= timePassed)
                {
                    return i;
                }
            }
            throw new Exception("No suitable operation has been found.");
        }
    }
}
