using System;

namespace FineCodeCoverageSpikeLibrary {

    using FineCodeCoverageSpikeLibrary.Contracts;

    public class Calculator : ICalculator {
        IResult _result;

        public Calculator(IResult result) {
            _result = result;
        }

        public int Add(int Value) {

            try {
                _result.Result = _result.Result + Value;
            }
            catch (Exception ex) {
                throw ex;
            }

            return _result.Result;
        }

        public int Div(int Value) {

            try {
                _result.Result = _result.Result / Value;
            }
            catch (DivideByZeroException dbzex) {
                throw dbzex;
            }
            catch (Exception ex) {
                throw ex;
            }

            return _result.Result;
        }

        public int Mult(int Value) {
            throw new NotImplementedException();
        }

        public int Sub(int Value) {

            try {
                _result.Result = _result.Result - Value;
            }
            catch (Exception ex) {
                throw ex;
            }

            return _result.Result;
        }
    }
}
