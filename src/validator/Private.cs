namespace validator
{
    internal class Private : IModifier
    {
        public bool Is(string modifier) =>
            modifier == "private";
    }
}