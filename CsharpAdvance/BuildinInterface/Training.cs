using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildinInterface
{
    public class Training : IEquatable<Training>
    {
        public Training (int trainngLength)
        {
            TrainingLength = trainngLength;
        }

        public int TrainingLength { get; set; }

        public bool Equals(Training? other)
        {
            return TrainingLength == other?.TrainingLength;
        }
    }
}
