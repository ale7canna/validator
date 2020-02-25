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
        private void method_has_public_modifier()
        {
            var method = "public void method()";

            var result = _sut.Compute(method);

            result.Public.Should().Be(true);
        }
    }

}