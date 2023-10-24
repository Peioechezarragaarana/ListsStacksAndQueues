using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;
    GenericListNode<T> Last = null;
    int pos = 0;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        GenericListNode<T> newNode;
        newNode = new GenericListNode<T>(value);
        if (First == null)
        {
            First = newNode;
            Last = newNode;
            pos = 1;
        }
        else
        {
            Last.Next = newNode;
            Last = newNode;
            pos = pos + 1;
            
        }
    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'
        int currentPos = 0;
        GenericListNode<T> currentNode = First;
        if (First == null)
        {
            return null;
        }
        while (currentPos < index && currentNode.Next != null)
        {
            currentNode = currentNode.Next;
            currentPos = currentPos + 1;
        }
        if (currentPos == index)
        {
            return currentNode;
        }

       
        return null;
    }

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
        int currentPos = 0;
        GenericListNode<T> currentNode = First;
        if (First == null)
        {
            return default(T);
        }
        while (currentPos < index && currentNode.Next != null)
        {
            currentNode = currentNode.Next;
            currentPos = currentPos + 1;
        }
        if (currentPos == index)
        {
            return currentNode.Value;
        }

       
        return default(T);
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list

        return pos;
    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        if (index == 0)
        {
            if (First != null)
            {
                First = First.Next;
                pos = pos - 1;
            }
            return;

        }
        else if (index >= 1)
        {

            if (FindNode(index) != null)
            {
                FindNode(index - 1).Next = FindNode(index + 1);
                Last = FindNode(index - 1);
            }

            pos = pos - 1;
        }
    }

    public void Clear()
    {
        pos = 0;
        First = null;
        Last = null;
        //TODO #6: remove all the elements on the list
    }
}