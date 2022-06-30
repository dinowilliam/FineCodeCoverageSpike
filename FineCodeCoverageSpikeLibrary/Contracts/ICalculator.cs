using System;

namespace FineCodeCoverageSpikeLibrary.Contracts {
    public interface ICalculator {
        Int32 Add(Int32 Value);
        Int32 Sub(Int32 Value);
        Int32 Mult(Int32 Value);
        Int32 Div(Int32 Value);
    }
}
