using System.Collections.Specialized;

namespace RegularCustomer
{
    public class Customer
    {
        public void Subscribe(Shop shop)
        {
            shop.SetCollectionChangedHandler(OnItemChanged);
        }

        private void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var addedItem = (Shop.Item)e.NewItems[0];
                    Console.WriteLine($"Товар был добавлен: Id = {addedItem.Id}, Name = {addedItem.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    var removedItem = (Shop.Item)e.OldItems[0];
                    Console.WriteLine($"Товар был удален: Id = {removedItem.Id}, Name = {removedItem.Name}");
                    break;
            }
        }
    }
}
