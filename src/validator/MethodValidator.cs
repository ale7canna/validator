namespace validator
{
    internal class MethodValidator
    {
        public Result Compute(string method) =>
            new Result
            {
                Modifier = method.StartsWith("public") ?
                    new Public() :
                    method.StartsWith("private") ?
                        (IModifier) new Private() :
                        new Internal()
            };
    }
}