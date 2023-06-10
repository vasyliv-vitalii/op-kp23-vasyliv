namespace hashtable
{
    class KeyValuePairs<Key, Value>
    {
        public Key key;
        public Value value;

        public KeyValuePairs(Key key, Value value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
