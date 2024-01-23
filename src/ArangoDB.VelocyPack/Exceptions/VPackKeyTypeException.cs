namespace ArangoDB.VelocyPack.Exceptions
{
    public class VPackKeyTypeException : VPackException
    {
        public VPackKeyTypeException(string message)
            : base(message)
        {
        }
    }
}
