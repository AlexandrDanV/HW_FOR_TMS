using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_ExeManager
{
    public class ExecutionManager
    {
        int _first;
        int _second;
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; }      

        public ExecutionManager(int _first, int _second)
        {
            this._first = _first;
            this._second = _second;
            FuncExecute = new Dictionary<Operation, Func<int>>();            
            PopulateFunction();
        }
        void PopulateFunction()//pass delegates and register
        {
            var _numOpers = Enum.GetNames(typeof(Operation)).Length;
            Func<int>[] funcs = new Func<int>[_numOpers];
            funcs[0] = () => _first + _second;
            funcs[1] = () => _first - _second;
            funcs[2] = () => _first * _second;
            PrepareExecution(funcs);
        }
        void PrepareExecution(Func<int>[] func)//fill dictionary here
        {
            for (int i = 0; i < func.Length; i++)
            {
                FuncExecute.Add((Operation)i, func[i]);
            }
        }
    }
}
