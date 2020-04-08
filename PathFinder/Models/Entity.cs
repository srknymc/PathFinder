using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Models
{
    // Class for selected Image
    public class MyImage
    {
        public Bitmap ImageData { get; set; } // Image data for iterate over pixel
        public Point StartPoint { get; set; } // selected start point
        public Point EndPoint { get; set; } // selected end point
        public Array _Array { get; set; } // Stack type Array
        public Heap Heap { get; set; } // Stack type Heap
        public Dictionary<Point, Point> Visited { get; set; } // visited nodes with parents <Node,Parent>
    }
    // class for pixel
    public class Node
    {
        public Point Point { get; set; } // pixel coord (x,y)
        public double Cost { get; set; } // Cost 
        public double PrevCost { get; set; } // prev node cost for A*
    }
    public class Array
    {
        public List<Node> _Array { get; set; } // Stack Type
        public int Size => _Array.Count; // returns Size
        public Array()
        {
            _Array = new List<Node>(); 
        }
        public void Add(Node n) // add funciton
        {
            _Array.Add(n);
        }
        public void Remove(Node n) // remove function
        {
            _Array.Remove(n);
        }
        public Node GetMin() // returns min cost node
        {
            int index = 0;
            double min = _Array[0].Cost;
            for (int i = 1; i < _Array.Count; i++)
            {
                if (_Array[i].Cost < min)
                {
                    min = _Array[i].Cost;
                    index = i;
                }
            }
            return _Array[index];
        }
    }
    // class for Stack type Heap (MAX-heap)
    public class Heap
    {
        public List<Node> Array { get; set; } // Stack Type
        public int Size => Array.Count; // returns Size
        public Heap()
        {
            Array = new List<Node>();
        }
        private int GetLeftChild(int index) => 2 * index + 1; // returns left child index
        private int GetRightChild(int index) => 2 * index + 2; // returns right child index
        private int GetParent(int index) => (index - 1) / 2; // returns parent index 
        public Node GetMin() => Array[0]; // returns min cost node
        private void Swap(int index, int index2) // swap given two index
        {
            var node = Array[index];
            Array[index] = Array[index2];
            Array[index2] = node;
        }
        private void HeapifyDown() // down heapify for after popping nodes
        {
            int index = 0;
            while (GetLeftChild(index) < Size)
            {
                var small = GetLeftChild(index);
                if (GetRightChild(index) < Size && Array[GetRightChild(index)].Cost < Array[GetLeftChild(index)].Cost)
                {
                    small = GetRightChild(index);
                }

                if (Array[small].Cost >= Array[index].Cost)
                {
                    break;
                }

                Swap(small, index);
                index = small;
            }
        }
        private void HeapifyUp() //up heapify after adding nodes
        {
            var index = Size - 1;
            while (index != 0 && Array[index].Cost < Array[GetParent(index)].Cost)
            {
                var pIndex = GetParent(index);
                Swap(pIndex, index);
                index = pIndex;
            }
        }
        public void Add(Node n) // add funciton
        {
            Array.Add(n);
            HeapifyUp();
        }
        public Node Pop() // pop function
        {
            if (Size > 0)
            {
                var node = Array[0];
                Swap(0, Size - 1);
                Array.RemoveAt(Size - 1);
                HeapifyDown();
                return node;
            }
            else
                return null;

        }
    }
}
