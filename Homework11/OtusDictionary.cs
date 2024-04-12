namespace Homework11
{
    public class OtusDictionary
    {
        private DictionaryEntry[] _entries = new DictionaryEntry[16];

        public string? this[int key]
        {
            get => Get(key);
            set => Add(key, value);
        }

        public string? Get(int key)
        {
            var index = GetEntryIndexByKey(key);
            var entry = _entries[index];
            return entry?.Value;
        }

        public void Add(int key, string? value) 
        {
            if (value == null) throw new ArgumentNullException("value");

            var index = GetEntryIndexByKey(key);
            var entry = _entries[index];
            if (entry == null) 
            {
                _entries[index] = new DictionaryEntry(key, value);
            }
            else if (entry.Key == key)
            {
                entry.Value = value;
            }
            else 
            {
                Console.WriteLine("Произошла коллизия, увеличиваю размер массива в 2 раза");
                ResizeDictionary();
            }
        }

        private int GetEntryIndexByKey(int key)
        {
            return 31 * Math.Abs(key) % _entries.Length;
        }

        private void ResizeDictionary()
        {
            var newSize = _entries.Length * 2;
            if (newSize < int.MaxValue)
            {
                var resizedEntries = new DictionaryEntry[newSize];
                foreach (var entry in _entries)
                {
                    if (entry != null)
                    {
                        Add(entry.Key, entry.Value);
                    }
                }
                _entries = resizedEntries;
            }
            else 
            {
                throw new InvalidOperationException("Массив переполнен");
            }
        }

        private class DictionaryEntry
        {
            public int Key { get; set; }
            public string Value { get; set; }

            public DictionaryEntry(int key, string value) {
                Key = key;
                Value = value;
            }
        }
    }
}
