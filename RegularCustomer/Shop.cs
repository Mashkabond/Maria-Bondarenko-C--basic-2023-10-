using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace RegularCustomer
{
    public class Shop
    {
        private ObservableCollection<Item> _items = new();
        private int _sequence;

        public void Add(string name)
        {
            _items.Add(new Item(_sequence++, name));
        }

        public void Remove(int id)
        {
            var item = _items.Where(item => item.Id == id).SingleOrDefault();
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        public void SetCollectionChangedHandler(NotifyCollectionChangedEventHandler handler)
        {
            _items.CollectionChanged += handler;
        }

        public class Item
        {
            public int Id { get; }
            public string Name { get; }

            public Item(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }
    }
}
