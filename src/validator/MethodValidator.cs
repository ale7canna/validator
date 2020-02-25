namespace validator
{
    internal class MethodValidator
    {
        public Result Compute(string method) =>
            new Result
            {
                Modifier = method.StartsWith("public") ?
                    (IModifier) new Public() :
                    new Internal()
            };
    }
}