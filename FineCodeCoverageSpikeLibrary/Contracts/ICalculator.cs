using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineCodeCoverageSpikeLibrary.Contracts {
    public interface ICalculator {
        Int32 Add(Int32 Value);
        Int32 Sub(Int32 Value);
        Int32 Mult(Int32 Value);
        Int32 Div(Int32 Value);
    }
}
