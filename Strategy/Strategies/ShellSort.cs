namespace Strategy.Strategies
{
    public class ShellSort : SortStrategy
    {
        /// <summary>
        /// A 'ConcreteStrategy' class
        /// </summary>
        /// <param name="list"></param>
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list");
        }
    }
}
