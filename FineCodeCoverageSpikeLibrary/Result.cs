using FineCodeCoverageSpikeLibrary.Contracts;
using System;

namespace FineCodeCoverageSpikeLibrary {
    public class Result : IResult {

        Int32 _result;        

        int IResult.Result { get => _result; set => _result = value; }
    }
}
