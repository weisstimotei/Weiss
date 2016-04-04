using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class Intersection
    {
        
        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public void RoadMovement(char direction, ref Point piece)
        {
            switch (direction)
            {
                case 'U':
                    piece = new Point(piece.x + 1, piece.y);
                    break;

                case 'D':
                    piece = new Point(piece.x - 1, piece.y);
                    break;

                case 'L':
                    piece = new Point(piece.x, piece.y - 1);
                    break;

                case 'R':
                    piece = new Point(piece.x, piece.y + 1);
                    break;
            }
            
        }
    }
}

