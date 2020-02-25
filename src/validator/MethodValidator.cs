namespace validator
{
    internal class MethodValidator
    {
        public Result Compute(string method) =>
            new Result
            {
                Public = true
            };
    }
}