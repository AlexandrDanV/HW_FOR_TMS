using Validation.InvalidExceptions;

namespace Validation.UnitTests
{
    public class ValidationTests
    {
        [Fact]
        public void CheckLogin_ReturnTrue()
        {
            var result = ValidationLogPass.CheckLogin("Sasha", 19, ' ');
            Assert.Equal(true, result);
        }

        [Fact]
        public void CheckPassword_ReturnTrue()
        {
            var result = ValidationLogPass.CheckPassword("DVD17", 19, ' ');
            Assert.Equal(true, result);
        }

        [Fact]
        public void ValidateLogin_ShouldWronLoginException()
        {
            var excep = Assert.Throws<WronLoginException>(() => ValidationLogPass.ValidateLogPass("DA d", "Dan1", "Dan1"));
        }
        [Fact]
        public void ValidatePass_ShouldWrongPassExcep()
        {
            var exep = Assert.Throws<WronPasswordException>(() => ValidationLogPass.ValidateLogPass("Dad", "DAn", "DAN"));

        }
    }
}
