namespace Generic
{
    public class MyStack<T>
    {
        private List<T> myStack = new List<T>();

        public void Push(T item)
        {
            myStack.Add(item);
        }

        public T? Pop()
        {
            if (myStack.Count <= 0)
            {
                throw new InvalidOperationException("The structure is empty");
            }

            var iten = myStack[myStack.Count - 1];
            myStack.RemoveAt(myStack.Count - 1);

            return iten;
        }

        public T? Peek()
        {
            if (myStack.Count <= 0)
            {
                throw new InvalidOperationException("The structure is empty");
            }

            var iten = myStack[myStack.Count - 1];

            return iten;
        }

        public int Count()
        {
            return myStack.Count;
        }

        public bool IsEmpty()
        {
           return Count() == 0 ? true : false;
        }
    }
}
