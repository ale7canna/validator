using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace validator.test
{
    public class ModifierChainTest
    {
        [Theory]
        [InlineData("modifier-a", typeof(ModifierA))]
        [InlineData("modifier-b", typeof(ModifierB))]
        [InlineData("", typeof(FallbackModifier))]
        [InlineData(null, typeof(FallbackModifier))]
        private void resolves_modifier(string modifier, Type expected)
        {
            var sut = new ModifierChain(new List<IModifier>
                {
                    new ModifierA(),
                    new ModifierB()
                },
                new FallbackModifier()
            );

            var result = sut.Resolve(modifier);

            result.Should().BeOfType(expected);
        }

        class ModifierA : IModifier
        {
            public bool Is(string modifier) =>
                modifier == "modifier-a";
        }

        class ModifierB : IModifier
        {
            public bool Is(string modifier) =>
                modifier == "modifier-b";
        }

        class FallbackModifier : IModifier
        {
            public bool Is(string modifier) =>
                true;
        }
    }
}