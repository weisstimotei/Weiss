using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HanoiTowers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMoveOneDisk()
        {
            int[] source = { 1, 2, 3 };
            int[] destination = new int[source.Length];
            int[] auxiliar = new int[source.Length];
            CollectionAssert.AreEqual(new int[] { 1, 0, 0 }, GetMoveDisks(3, source, destination, auxiliar));
        }
        public int[] GetMoveDisks(int disk, int[] source, int[] destination, int[] auxiliar)
        {
            if (disk == 1)
            {
                destination[disk - 1] = source[disk - 1];
                Array.Resize(ref source, source.Length - 1);
            }
            else
            {
                GetMoveDisks(disk - 1, source, auxiliar, destination);
            }
            return destination;
        }

    }
}
