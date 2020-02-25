using System.Collections.Generic;
using System.Linq;

namespace validator
{
    internal class MethodValidator
    {
        private readonly ModifierChain _modifierChain;

        public MethodValidator()
        {
            _modifierChain = new ModifierChain(
                new List<IModifier>
                {
                    new Public(),
                    new Internal(),
                    new Private()
                },
                new Internal());
        }

        public Result Compute(string method) =>
            new Result
            {
                Modifier = _modifierChain.Resolve(method.Split(" ").First())
            };
    }
}