using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intersection
{
    [TestClass]
    public class Intersection
    {
        [TestMethod]
        public void TestIfPointsCoordinateAreDifferent()
        {
            Assert.AreNotEqual(new Point(0, 0), new Point(0, 1));
        }
        [TestMethod]
        public void TestIncreaseXDirection()
        {
            Assert.AreEqual(new Point(0, 0), GetTheFirsIntersectionPoint("R"));
        }
        [TestMethod]
        public void TestIncreaseAndDecreaseYDirection()
        {
            Assert.AreEqual(new Point(0, 0), GetTheFirsIntersectionPoint("UD"));
        }
        [TestMethod]
        public void TestIntersectionBasedOnStringUUURRDLU()
        {
            Assert.AreEqual(new Point(1, 3), GetTheFirsIntersectionPoint("UUURRDLU"));
        }
        public struct Point
        {
            public int x,y;
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
                case 'R':
                    piece = new Point(piece.x + 1, piece.y);
                    break;

                case 'L':
                    piece = new Point(piece.x - 1, piece.y);
                    break;

                case 'D':
                    piece = new Point(piece.x, piece.y - 1);
                    break;

                case 'U':
                    piece = new Point(piece.x, piece.y + 1);
                    break;
            }
        }
        public Point GetTheFirsIntersectionPoint(string path)
        {
            Point start = new Point(0, 0);
            Point[] points = { start };
            Point actual = points[points.Length - 1];
            foreach (char item in path)
            {
                RoadMovement(item, ref actual);
                if (CeckForIntersection(actual, points))
                {
                    return actual;
                }
                else
                {
                    Array.Resize(ref points, points.Length + 1);
                    points[points.Length - 1] = actual;
                }
            }
            return start;
        }
        private bool CeckForIntersection(Point actual, Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (actual.x == points[i].x && actual.y == points[i].y)
                    return true;
            }
            return false;
        }


    }
}

