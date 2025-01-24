using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_ExeManager
{
    public class OperationManager
    {
        private int _first;
        private int _second;
        static ExecutionManager exeManager;

        public OperationManager(int first, int second)
        {
            exeManager = new ExecutionManager(this);
            _first = first;
            _second = second;
        }
        internal int Sum()
        {
            return _first + _second;
        }
        internal int Subtract()
        {
            return _first - _second;
        }
        internal int Multiply()
        {
            return _first * _second;
        }
        public int Execute(Operation operation)
        {
            return exeManager.FuncExecute[operation]();
        }
    }
}
