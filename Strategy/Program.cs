using Strategy.Strategies;

// Two context fallowing different strategies

Strategy.SortedList studentRecords = new Strategy.SortedList();

studentRecords.Add("Samual");
studentRecords.Add("Jimmy");
studentRecords.Add("Sandra");
studentRecords.Add("Vivek");
studentRecords.Add("Anna");

studentRecords.SetSortStrategy(new QuickSort());
studentRecords.Sort();

studentRecords.SetSortStrategy(new ShellSort());
studentRecords.Sort();

studentRecords.SetSortStrategy(new MergeSort());
studentRecords.Sort();

// Wait for user

Console.ReadKey();