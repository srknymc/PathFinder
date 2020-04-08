using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Models
{
    public static class AppHelper
    {
        public static int MaxSize { get; set; } //MAX stack size
        public static int PopCount { get; set; } //Number of popped elements
        public static double EuclidDistance(Point point, Point dest) // H cost function
        {
            return Math.Sqrt(Math.Pow((point.X - dest.X), 2) + Math.Pow((point.Y - dest.Y), 2));
        }
        public static double GFunc(Bitmap ImageData, Point point) // G func for A*
        {
            double red = 255 - ImageData.GetPixel(point.X, point.Y).R;
            return (red == 0) ? 1 : red;
        }
        //public static Node FindMin(List<Node> Array)
        //{
        //    int index = 0;
        //    double min = Array[0].Cost;
        //    for (int i = 1; i < Array.Count; i++)
        //    {
        //        if (Array[i].Cost < min)
        //        {
        //            min = Array[i].Cost;
        //            index = i;
        //        }
        //    }
        //    return Array[index];
        //}
        public static void AddNeighbours(MyImage entity, Node node, byte type, bool isHeap) // Adding Avaible nodes to Heap or Array 
        {
            int[] x = { -1, 0, 0, 1 };
            int[] y = { 0, -1, 1, 0 };
            for (int i = 0; i < 4; i++)
            {
                int X = node.Point.X + x[i];
                int Y = node.Point.Y + y[i];
                Point tmp = new Point(X, Y);
                if (!entity.Visited.ContainsKey(tmp) && checkRange(entity, tmp)) // if node not visited and in range of image data
                {
                    entity.Visited.Add(tmp, node.Point);

                    if (isHeap) //HEAP
                    {
                        if (type == 0) //BFS
                        {
                            entity.Heap.Add(new Node { Point = tmp, Cost = EuclidDistance(tmp, entity.EndPoint) });
                            if (entity.Heap.Size > MaxSize) //Updating Max size of Stack
                                MaxSize = entity.Heap.Size;
                        }
                        else //AStar
                        {
                            double totalG = GFunc(entity.ImageData, tmp) + node.PrevCost;
                            entity.Heap.Add(new Node { Point = tmp, Cost = EuclidDistance(tmp, entity.EndPoint) + totalG, PrevCost =totalG});
                            if (entity.Heap.Size > MaxSize)
                                MaxSize = entity.Heap.Size;
                        }
                    }
                    else//STACK
                    {
                        if (type == 0) //BFS
                        {
                            entity._Array.Add(new Node { Point = tmp, Cost = EuclidDistance(tmp, entity.EndPoint) });
                            if (entity._Array.Size > MaxSize)
                                MaxSize = entity._Array.Size;
                        }
                        else //AStar
                        {
                            double totalG = GFunc(entity.ImageData, tmp) + node.PrevCost;
                            entity._Array.Add(new Node { Point = tmp, Cost = EuclidDistance(tmp, entity.EndPoint) + totalG, PrevCost=totalG });
                            if (entity._Array.Size > MaxSize)
                                MaxSize = entity._Array.Size;
                        }
                    }
                }
            }

        }
        public static bool checkRange(MyImage entity, Point point) //Range checking function
        {
            if (point.X >= entity.ImageData.Width || point.X < 0 || point.Y >= entity.ImageData.Height || point.Y < 0)
                return false;
            return true;
        }

    }
    public static class Algorithms
    {
        public static bool BFS_Arr(MyImage Entity) // BFS with Array
        {
            AppHelper.MaxSize = 0;
            AppHelper.PopCount = 0;
            Entity._Array.Add(new Node { Point = Entity.StartPoint, Cost = AppHelper.EuclidDistance(Entity.StartPoint, Entity.EndPoint) });
            Node node = new Node();
            bool isFound = false; //
            while (Entity._Array.Size != 0 && !isFound) // while stack not empty and not found
            {
                node = Entity._Array.GetMin(); // get min element
                Entity._Array.Remove(node); // remove min
                AppHelper.PopCount++; //increase pop count

                if (node.Point != Entity.EndPoint) // checking arrived endpoint
                {
                    AppHelper.AddNeighbours(Entity, node, 0, false);
                }
                else
                {
                    isFound = true;
                }
            }
            return isFound;
        }
        public static bool BFS_Heap(MyImage Entity)
        {
            AppHelper.MaxSize = 0;
            AppHelper.PopCount = 0;
            Entity.Heap.Add(new Node { Point = Entity.StartPoint, Cost = AppHelper.EuclidDistance(Entity.StartPoint, Entity.EndPoint) });
            Node node = new Node();
            bool isFound = false;
            while (Entity.Heap.Size != 0 && !isFound)
            {
                node = Entity.Heap.GetMin();
                Entity.Heap.Pop();
                AppHelper.PopCount++;

                if (node.Point != Entity.EndPoint)
                {
                    AppHelper.AddNeighbours(Entity, node, 0, true);
                }
                else
                {
                    isFound = true;
                }
            }
            return isFound;
        }
        public static bool AStar_Arr(MyImage Entity)
        {
            AppHelper.MaxSize = 0;
            AppHelper.PopCount = 0;
            Entity._Array.Add(new Node { Point = Entity.StartPoint, Cost = AppHelper.EuclidDistance(Entity.StartPoint, Entity.EndPoint), PrevCost = 0 });
            Node node = new Node();
            bool isFound = false;
            while (Entity._Array.Size != 0 && !isFound)
            {
                node = Entity._Array.GetMin();
                Entity._Array.Remove(node);
                AppHelper.PopCount++;

                if (node.Point != Entity.EndPoint)
                {
                    AppHelper.AddNeighbours(Entity, node, 1, false);
                }
                else
                {
                    isFound = true;
                }
            }
            return isFound;

        }
        public static bool AStar_Heap(MyImage Entity)
        {
            AppHelper.MaxSize = 0;
            AppHelper.PopCount = 0;
            Entity.Heap.Add(new Node { Point = Entity.StartPoint, Cost = AppHelper.EuclidDistance(Entity.StartPoint, Entity.EndPoint), PrevCost = 0 });
            Node node = new Node();
            bool isFound = false;
            while (Entity.Heap.Size != 0 && !isFound)
            {
                node = Entity.Heap.GetMin();
                Entity.Heap.Pop();
                AppHelper.PopCount++;
                if (node.Point != Entity.EndPoint)
                {
                    AppHelper.AddNeighbours(Entity, node, 1, true);
                }
                else
                {
                    isFound = true;
                }
            }
            return isFound;

        }
    }

}
