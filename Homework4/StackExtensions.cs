namespace Homework4
{
    public static class StackExtensions
    {
        public static Stack Merge(this Stack stack, Stack stackToMerge)
        {
            while (stackToMerge.Size != 0) 
            {
                stack.Add(stackToMerge.Pop());
            } 

            return stack;
        }
    }
}
