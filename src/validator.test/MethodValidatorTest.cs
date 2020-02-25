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

        [Fact]
        private void if_not_specified_method_is_not_public()
        {
            var method = "void method()";

            var result = _sut.Compute(method);

            result.Public.Should().Be(false);
        }
    }

}