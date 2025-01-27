using HW11_ExeManager;

namespace UnitTestsApp.Tests
{
    public class ExecutionManaderTests
    {
        [Fact]
        public void ExecuteSum_ShouldSuccess()
        {
            var manager = new OperationManager(7, 3);
            var result = manager.Execute(Operation.Sum);
            Assert.Equal(10, result);
        }
        [Fact]
        public void ExecuteMultiply_ShouldSuccess()
        {
            var manager = new OperationManager(7, 3);
            var result = manager.Execute(Operation.Multiply);
            Assert.Equal(21, result);
        }
        [Fact]
        public void ExecuteSubtract_ShouldSuccesst()
        {
            var manager = new OperationManager(7, 3);
            var result = manager.Execute(Operation.Subtract);
            Assert.Equal(4, result);
        }
        [Fact]
        public void FuncExecute_ShouldSuccess()
        {
            var manager = new ExecutionManager(7, 3);
            Assert.NotEmpty(manager.FuncExecute);
        }
    }
}
