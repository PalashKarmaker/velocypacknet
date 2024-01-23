namespace ArangoDB.VelocyPack.Exceptions
{
    public class VPackBuilderNumberOutOfRangeException : VPackBuilderException
    {
        public VPackBuilderNumberOutOfRangeException(SliceType type)
            : base(string.Format("Number out of range of {0}", type))
        {
        }
    }
}
