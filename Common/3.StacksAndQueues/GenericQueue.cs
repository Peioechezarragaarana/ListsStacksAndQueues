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
            return myList.AsString();
            //TOD= #2: Return the list as a string. Use the method already implemented in your list
           
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return myList.Count();
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            myList.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            myList.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it

            
            T t;
            t = myList.Get(0);
            myList.Remove(0);
            return t;
        }
    }
}