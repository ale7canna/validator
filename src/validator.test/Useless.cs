using FluentAssertions;
using Xunit;

namespace validator.test
{
    public class Useless
    {
        [Fact]
        private void pass()
        {
            true.Should().Be(true);
        }
    }
}