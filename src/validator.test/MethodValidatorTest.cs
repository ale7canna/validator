using FluentAssertions;
using Xunit;

namespace validator.test
{
    public class MethodValidatorTest
    {
        private readonly MethodValidator _sut;

        public MethodValidatorTest()
        {
            _sut = new MethodValidator();
        }

        [Fact]
        private void method_can_be_public()
        {
            var method = "public void method()";

            var result = _sut.Compute(method);

            result.Modifier.Should().BeOfType<Public>();
        }

        [Fact]
        private void method_is_internal_by_default()
        {
            var method = "void method()";

            var result = _sut.Compute(method);

            result.Modifier.Should().BeOfType<Internal>();
        }

        [Fact]
        private void method_can_be_private()
        {
            var method = "private void method()";

            var result = _sut.Compute(method);

            result.Modifier.Should().BeOfType<Private>();
        }
    }
}