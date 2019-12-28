using System;

namespace Chronic_Disease_Prediction
{
    public class DataInput
    {
        [LoadColumn(0)]
        public int Age { get; set; }
    }
}
