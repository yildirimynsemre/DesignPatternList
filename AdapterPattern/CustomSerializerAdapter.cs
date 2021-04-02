namespace AdapterPattern
{
    class CustomSerializerAdapter : IJsonSerializer
    {
        public string SerializeObject(object obj)
        {
            CustomSerializer customSerializer = new CustomSerializer();
            return customSerializer.Serialize(obj);
        }
    }
}
