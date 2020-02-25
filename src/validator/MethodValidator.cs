namespace validator
{
    internal class MethodValidator
    {
        public Result Compute(string method) =>
            new Result
            {
                Public = method.StartsWith("public")
            };
    }
}