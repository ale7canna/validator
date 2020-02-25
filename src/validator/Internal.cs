namespace validator
{
    internal class Internal : IModifier
    {
        public bool Is(string modifier) =>
            modifier == "internal";
    }
}