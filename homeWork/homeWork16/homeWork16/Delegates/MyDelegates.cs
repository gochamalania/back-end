namespace homeWork16.Delegates;

// public class MyDelegates
// {
//     
// }

public delegate bool MyPredicate<T>(T item);

public delegate TKey MySelector<T, TKey>(T item);