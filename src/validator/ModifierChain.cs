using System.Collections.Generic;
using System.Linq;

namespace validator
{
    internal class ModifierChain
    {
        private readonly List<IModifier> _modifiers;
        private readonly IModifier _fallbackModifier;

        public ModifierChain(List<IModifier> modifiers, IModifier fallbackModifier)
        {
            _modifiers = modifiers;
            _fallbackModifier = fallbackModifier;
        }

        public IModifier Resolve(string modifier) =>
            _modifiers.SingleOrDefault(x => x.Is(modifier))
            ?? _fallbackModifier;
    }
}