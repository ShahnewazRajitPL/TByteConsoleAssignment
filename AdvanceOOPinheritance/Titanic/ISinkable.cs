using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanic
{
    public interface ISinkable
    {
        public int SinkDuration { get; set; }

        public void Sink();
    }
}
