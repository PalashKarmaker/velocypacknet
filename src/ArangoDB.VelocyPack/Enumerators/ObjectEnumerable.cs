using System.Collections;

namespace ArangoDB.VelocyPack.Enumerators
{
    public class ObjectEnumerable : IEnumerable<KeyValuePair<string, VPackSlice>>
    {
        VPackSlice slice;

        public ObjectEnumerable(VPackSlice slice)
        {
            this.slice = slice;
        }

        public IEnumerator<KeyValuePair<string, VPackSlice>> GetEnumerator()
        {
            return new ObjectEnumerator(slice);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ObjectEnumerator(slice);
        }
    }
}
