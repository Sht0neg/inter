namespace Sort.Tests
{
    public class Tests
    {
        List<int> integers;
        [SetUp]
        public void Setup()
        {
            integers = new() { 2, 5, 1, 2, 4, 8, 4, 3, 5 };
        }

        [Test]
        public void BubbleSortTest()
        {
            List<int> newintegers = new Sorts().BubbleSort(integers);
            Assert.IsTrue(newintegers[0] == 1 && newintegers[newintegers.Count - 1] == 8);
        }
        [Test]
        public void InsertionSortTest() {
            List<int> newintegers = new Sorts().InsertionSort(integers);
            Assert.IsTrue(newintegers[0] == 1 && newintegers[newintegers.Count - 1] == 8);
        }
    }
}