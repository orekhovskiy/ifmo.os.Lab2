using System;
using System.Collections.Generic;
using System.Text;

namespace ifmo.os.Lab2
{
    public class Operation
    {
        public int TimeArrived { get; }
        public int TimeLeaved { get; set; }
        public int OperatingTime { get; }

        public Operation(int timeArrived, int operatingTime)
        {
            TimeArrived = timeArrived;
            OperatingTime = operatingTime;
        }
    }
}
