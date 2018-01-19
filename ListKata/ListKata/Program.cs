using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKata
{
    class Program
    {
        static void Main(string[] args)
        {



        }
    }

    public class boringNode
    {
        public boringNode(string s)
        {
            theString = s;
        }
        public string theString;
    }

    public class myArrayList
    {
        public boringNode[] theArray = new boringNode[0];

        public boringNode contains(string s)
        {
            foreach (var node in theArray)
            {
                if (node.theString == s)
                {
                    return node;
                }
            }
            return null;
        }

        public string[] ToArray()
        {
            var array = new string[theArray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = theArray[i].theString;
            }
            return array;
        }

        public void Add(string s)
        {
            var newArray = new boringNode[theArray.Length + 1];
            for (int i = 0; i < theArray.Length; i++)
            {
                newArray[i] = theArray[i];
            }
            newArray[theArray.Length]=new boringNode(s);
            theArray = newArray;
        }

        public void Remove(boringNode node)
        {
            var newArray = new boringNode[theArray.Length -1];
            bool flag = false;
            for (int i = 0; i < theArray.Length-1; i++)
            {
                if (ReferenceEquals(node, theArray[i]))
                {
                    flag = true;
                }

                    newArray[i] = !flag ? theArray[i] : theArray[i + 1];
           
            }
            if (!flag && !ReferenceEquals(node,theArray[theArray.Length-1]))
            {
                return;
            }
            else
            {
                theArray = newArray;
            }
        }

    }

    public class SLLList
    {
        public SLLNode TheFirstNode;

        public void Add(string s)
        {
            SLLNode node = new SLLNode(s);
            if (TheFirstNode == null)
            {
                TheFirstNode = node;
            }
            else
            {
                TheFirstNode.add(node);
            }

        }

        public SLLNode contains(string s)
        {
            return TheFirstNode?.contains(s);
        }

        public void Remove(SLLNode node)
        {
            if (ReferenceEquals(TheFirstNode, node) && TheFirstNode != null)
            {
                TheFirstNode = TheFirstNode?.nextNode;
            }
            else
            {
                TheFirstNode.Remove(node);
            }
        }

        public string[] ToArray()
        {
            if (TheFirstNode == null)
            {
                return new string[0];
            }
            return (TheFirstNode == null) ? new string[0]: TheFirstNode.DisplayAllNodes(new string[0]);
        }

    }

    public class SLLNode
    {
        public SLLNode(string theString)
        {
            this.theString = theString;
        }

        public SLLNode nextNode;

        public string theString;

        public void add(SLLNode node)
        {
            if (nextNode != null)
            {
                nextNode.add(node);
            }
            else
            {
                nextNode = node;
            }
        }

        public SLLNode contains(string s)
        {
            if (theString == s)
            {
                return this;
            }
            return nextNode?.contains(s);
        }

        public void Remove(SLLNode node)
        {
            if(ReferenceEquals(nextNode,node))
            {
                nextNode = nextNode.nextNode;
            }
            else
            {
                nextNode?.Remove(node);
            }
        }

        public string[] DisplayAllNodes(string[] prevNodes)
        {
            var nodes = new string[prevNodes.Length + 1];
            for (int i = 0; i < prevNodes.Length; i++)
            {
                nodes[i] = prevNodes[i];
            }
            nodes[prevNodes.Length] = theString;

            if (nextNode == null)
            {
                return nodes;
            }
            return nextNode.DisplayAllNodes(nodes);

        }
    }

}
