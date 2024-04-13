namespace Homework13
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent)
        {
            ValidatePercent(percent);
            var limit = (int)Math.Ceiling(collection.Count() * percent / 100.0);
            return (
                from item in collection
                orderby item descending
                select item
                   )
                .Take(limit);
        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent, Func<T, int> orderByFunc)
        {
            ValidatePercent(percent);
            var limit = (int)Math.Ceiling(collection.Count() * percent / 100.0);
            return collection
                .OrderByDescending(orderByFunc)
                .Take(limit);
        }

        private static void ValidatePercent(int percent)
        {
            if (percent < 1 || percent > 100)
            {
                throw new ArgumentException("Процент должен иметь значение от 1 до 100");
            }
        }
    }
}
