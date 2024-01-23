namespace ArangoDB.VelocyPack
{
    public interface IVPackAttributeTranslator
    {
        void Add(string attribute, int key);

        void Seal();

        VPackSlice Translate(string attribute);

        VPackSlice Translate(int key);
    }
}
