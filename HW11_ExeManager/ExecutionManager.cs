using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_ExeManager
{
    public class ExecutionManager
    {
        private int _first;
        private int _second;
        public Dictionary<Operations, Func<int>> FuncExecute { get; set; }

        public ExecutionManager(int first, int second)
        {
            _first = first;
            _second = second;
            PrepareExecution();
        }
        public void PrepareExecution()
        {
            FuncExecute = new()
            {
                [Operations.Sum] = () => _first + _second,
                [Operations.Subtract] = () => _first - _second,
                [Operations.Multiply] = () => _first * _second,
            };
        }
        public int Execute(Operations opers)
        {
            var res = opers switch
            {
                Operations.Sum => FuncExecute[Operations.Sum](),
                Operations.Multiply => FuncExecute[Operations.Multiply](),
                Operations.Subtract => FuncExecute[Operations.Subtract](),
                _ => -1
            };
            return res;
        }
    }
}
