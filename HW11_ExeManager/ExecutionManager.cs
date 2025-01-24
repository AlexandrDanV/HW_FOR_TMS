using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_ExeManager
{
    public class ExecutionManager
    {
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; }
        private readonly OperationManager operationManager;

        public ExecutionManager(OperationManager operationManager)
        {
            FuncExecute = new Dictionary<Operation, Func<int>>();
            this.operationManager = operationManager;
            PopulateFunction();
        }
        void PopulateFunction()//pass delegates and register
        {
            var _numOpers = Enum.GetNames(typeof(Operation)).Length;
            Func<int>[] funcs = new Func<int>[_numOpers];
            funcs[0] = () => operationManager.Sum();
            funcs[1] = () => operationManager.Subtract();
            funcs[2] = () => operationManager.Multiply();
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
