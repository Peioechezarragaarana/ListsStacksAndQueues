namespace Common
{

    public class GenericQueue<T> : IPushPop<T>
    {
        GenericList<T> myList;
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        public GenericQueue()
        {
            myList = new GenericList<T>();
        }

        public string AsString()
        {
            //TOD= #2: Return the list as a string. Use the method already implemented in your list
            return null;
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return 0;
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it

            return default(T);
        }
    }
}