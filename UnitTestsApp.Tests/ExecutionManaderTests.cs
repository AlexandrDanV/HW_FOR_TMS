using HW11_ExeManager;

namespace UnitTestsApp.Tests
{
    public class ExecutionManaderTests
    {
        [Fact]
        public void ExecuteSum_Test()
        {
            var manager = new ExecutionManager(2, 3);
            var result = manager.Execute(Operations.Sum);
            Assert.Equal(5, result);
        }
        [Fact]
        public void ExecuteMultiply_Test()
        {
            var manager = new ExecutionManager(2, 3);
            var result = manager.Execute(Operations.Multiply);
            Assert.Equal(6, result);
        }
        [Fact]
        public void ExecuteSubtract_Test()
        {
            var manager = new ExecutionManager(2, 3);
            var result = manager.Execute(Operations.Subtract);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test_DictionaryNotEmpty()
        {
            var manager = new ExecutionManager(2, 3);
            Assert.NotEmpty(manager.FuncExecute);
        }
    }
}
