using System;
using System.Collections.Generic;
using System.Text;

namespace ifmo.os.Lab2.Algorithms
{
    public interface IAlgorithm
    {
        public int Pick(List<Operation> operations, int timePassed);
    }
}
