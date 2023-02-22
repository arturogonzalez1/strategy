namespace Strategy
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string item)
        {
            _list.Add(item);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            // Iterate over list and display results

            _list.ForEach(item => Console.WriteLine(" " + item));

            Console.WriteLine();
        }
    }
}
