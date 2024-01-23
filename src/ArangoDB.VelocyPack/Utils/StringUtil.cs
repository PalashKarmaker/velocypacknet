using System.Text;

namespace ArangoDB.VelocyPack.Utils
{
    public class StringUtil
    {
        private StringUtil()
        {
        }

        public static string ToString(byte[] array, int offset, int length)
        {
            return Encoding.UTF8.GetString(array, offset, length);
        }
    }
}
