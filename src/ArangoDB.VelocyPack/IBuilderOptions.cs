namespace ArangoDB.VelocyPack
{
    public interface IBuilderOptions
    {
        bool IsBuildUnindexedArrays();

        void SetBuildUnindexedArrays(bool buildUnindexedArrays);

        bool IsBuildUnindexedObjects();

        void SetBuildUnindexedObjects(bool buildUnindexedObjects);

        bool IsBuildCompactIntegers();

        void SetBuildCompactIntegers(bool buildCompactIntegers);
    }
}
