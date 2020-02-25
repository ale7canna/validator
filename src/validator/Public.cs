namespace validator
{
    internal class Public : IModifier
    {
        public bool Is(string modifier) =>
            modifier == "public";
    }
}