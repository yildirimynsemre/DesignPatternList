namespace AdapterPattern
{
    class CustomOperation
    {
        private IJsonSerializer _jsonSerializer;

        public CustomOperation(IJsonSerializer jsonSerializer)
        {
            _jsonSerializer = jsonSerializer;
        }

        public string SerializeObject(object obj)
        {
            return _jsonSerializer.SerializeObject(obj);
        }
    }
}
