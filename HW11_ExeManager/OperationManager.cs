using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11_ExeManager
{
    public class OperationManager
    {        
        static ExecutionManager exeManager;

        public OperationManager(int first, int second)
        {
            exeManager = new ExecutionManager(first, second);
        }

        public int Execute(Operation operation)
        {
            return exeManager.FuncExecute[operation]();
        }
    }
}
