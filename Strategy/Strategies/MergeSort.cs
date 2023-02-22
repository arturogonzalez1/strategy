namespace Strategy.Strategies
{
    public class MergeSort : SortStrategy
    {
        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        /// <param name="list"></param>
        public override void Sort(List<string> list)
        {
            // list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list");
        }
    }
}
