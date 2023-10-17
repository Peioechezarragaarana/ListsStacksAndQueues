using System;
using System.ComponentModel.Design;
using System.Text.Json.Nodes;
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
            /**
            IntListNode node = First;
            IntListNode newNode;
            while (node != null)
            {
                node = node.Next;
            }
            newNode = new IntListNode(value);
            node.Next = newNode;  
            pos ++;
            */
            //Con menos orden de complejidad O(1)
            IntListNode newNode;
            newNode = new IntListNode(value);
            IntListNode lasFirst = Last;
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
                currentPos= currentPos + 1; 
            }
            if (currentPos == index)
            {
                return currentNode;
            }
  
            return null;
        }

        
        public int Get(int index)

            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            /**
            IntListNode intListNode = GetNode(index);
            if (intListNode != null)
            {
                return intListNode.Value;
            }
            else
            {
                return 0;
            }
        }
            */
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
            // Sin mejorar
            /**
            IntListNode currentNode = First;
            int cont= 0;    
                
            while (currentNode != null)
            {
                currentNode= currentNode.Next;  
                 cont ++;
            }

            return cont;
        }*/


            //MEJORADO 
            return pos;
        }

        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            int currentPos = 0;

            IntListNode node = GetNode(index);
            if (node.cont != 1) { }
            IntListNode antNode = GetNode(index - 1);
            IntListNode nextNode = GetNode(index + 1);


            if (node != null)
            {
                if (node.Next != null)
                {
                    antNode.Next = node;

                }
                else
                {
                    antNode.Next = null;
                    Last = antNode;
                }

                pos = pos - 1;
            }
            else
            {
                First = nextNode;
            }
        }

           

            /**
            while ( currentPos < index - 1 && node != null) 
            { 
            
                node = node.Next;   
                currentPos++;
            
            }
            antNode= node;     

            if ( node.Next!=null && )
            {
                node.
            }
            pos = pos - 1;
            */


        
        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            First = null;
        }
    }
}