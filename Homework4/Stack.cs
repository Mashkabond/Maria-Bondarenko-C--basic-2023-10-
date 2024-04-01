namespace Homework4
{
    public class Stack
    {
        public string? Top { get; private set; }
        public int Size { get; private set; }

        private StackItem? _top;

        public Stack(params string[] values) 
        {
            if (values != null) 
            {
                foreach (var value in values)
                {
                    Add(value);
                }
            }
        }

        public void Add(string? newValue)
        {
            _top = new StackItem(newValue, _top);
            Top = _top.Value;
            Size++;
        }

        public string? Pop()
        {
            if (Size == 0) throw new InvalidOperationException("Стек пустой");
            
            var value = Top;
            _top = _top?.PreviousItem;
            Top = _top?.Value;
            Size--;
            return value;
        }

        public static Stack Concat(params Stack[] stacks)
        {
            var concatenatedStack = new Stack();

            foreach (var stack in stacks)
            {
                while (stack.Size != 0) 
                {
                    concatenatedStack.Add(stack.Pop());
                }
            }

            return concatenatedStack;
        }

        private class StackItem
        {
            public string? Value { get; }
            public StackItem? PreviousItem { get; }

            public StackItem(string? value, StackItem? previousItem = null)
            {
                Value = value;
                PreviousItem = previousItem;
            }
        }
    }
}
