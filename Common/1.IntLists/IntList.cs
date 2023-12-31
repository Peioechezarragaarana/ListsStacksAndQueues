using System;
using System.ComponentModel.Design;
using System.Text.Json.Nodes;
using System.Timers;
using System.Transactions;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;
        public int cont;

        public IntListNode(int value)
        {
            Value = value;
            cont = 0;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;
        int pos = 0;
        IntListNode Last = null;
        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }


        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
         
            IntListNode newNode;
            newNode = new IntListNode(value);
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
                newNode.cont = pos;
            }
        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            int currentPos = 0;
            IntListNode currentNode = First;
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


        public int Get(int index)

        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
        
        {
            //TODO #2: Return the element in position 'index'
            int currentPos = 0;
            IntListNode currentNode = First;
            if (First == null)
            {
                return 0;
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

            return 0;
        }


        public int Count()
        {
            //TODO #4: return the number of elements on the list
          
            return pos;
        }

        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if (index==0) 
            {
                if (First!=null) 
                {
                    First = First.Next;
                    pos = pos - 1;
                }
                return;
                
            }
            else if (index >= 1)
            {

                if (GetNode(index) != null)
                {
                        GetNode(index - 1).Next = GetNode(index + 1);
                        Last = GetNode(index - 1);
                }

                    pos = pos - 1;
                }
            
           
        }

        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            First = null;
            Last = null;    
            pos = 0;
        }
    }
}