namespace GenericSerializer.Base
{
    public interface IGenericSerializer<T>
    {
        void SerializeToFile(T objectData, string fileName);
        string SerializeToString(T objectData);
        T DeserializeFromFile(string fileName);
        T DeserializeFromString(string mediaTypeString);
        T DeserializeFromLink(string link);
    }
}
