using System.ComponentModel;
using homeWork16.Delegates;

namespace homeWork16.Extensions;

public static class MyEnumerable
{
    // where
    public static List<T> Where<T>(List<T> collection, MyPredicate<T> predicate)
    {
        List<T> result = new List<T>();

        foreach (T item in collection)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result;
    }
    
    // any
    public static bool Any<T>(List<T> collection, MyPredicate<T> predicate)
    {
        foreach (T item in collection)
        {
            if (predicate(item))
            {
                return true;
            }
        }
        return false;
    }
    
    // all
    public static bool All<T>(List<T> collection, MyPredicate<T> predicate)
    {
        foreach (T item in collection)
        {
            if (!predicate(item))
            {
                return false;
            }
        }
        return true;
    }
    
    // count
    public static int Count<T>(List<T> collection, MyPredicate<T> predicate)
    {
        int count = 0;
        
        foreach (T item in collection)
        {
            if (predicate(item))
            {
                count++;
            }
        }
        return count;
    }
    
    // first
    public static T First<T>(List<T> collection, MyPredicate<T> predicate)
    {
        foreach (T item in collection)
        {
            if (predicate(item))
            {
                return item;
            }
        }
        throw new Exception("No such element");
    }
    
    // firstOrDefault
    public static T FirstOrDefault<T>(List<T> collection, MyPredicate<T> predicate)
    {
        foreach (T item in collection)
        {
            if (predicate(item))
            {
                return item;
            }
        }
        return default;
    }
    
    // single
    public static T Single<T>(List<T> collection, MyPredicate<T> predicate)
    {
        int count = 0;
        
        T result = default(T);

        foreach (T item in collection)
        {
            if (predicate(item))
            {
                count++;
                result = item;
            }
        }

        if (count == 1)
        {
            return result;
        }
        
        throw new Exception("Single() method must return exactly one element");
    }
    
    // singleOrDefault
    public static T SingleOrDefault<T>(List<T> collection, MyPredicate<T> predicate)
    {
        int count = 0;
        T result = default(T);

        foreach (T item in collection)
        {
            if (predicate(item))
            {
                count++;
                result = item;
            }
        }

        if (count == 0)
        {
            return default(T);
            
        }
        
        if (count == 1)
        {
            return result;
        }
        
        throw new Exception("Single() method found more than one element");
    }
    
    // distinct
    public static List<T> Distinct<T>(List<T> collection)
    {
        List<T> result = new List<T>();

        foreach (T item in collection)
        {
            bool exists = false;

            foreach (T uniqueItem in result)
            {
                if (uniqueItem.Equals(item))
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                result.Add(item);
            }
        }
        return result;
    }
    
    // orderBy
    public static List<T> OrderBy<T, TKey>(List<T> collection, MySelector<T, TKey> selector) where TKey : IComparable
    {
        List<T> result = new List<T>();

        foreach (T item in collection)
        {
            result.Add(item);
        }

        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = 0; j < result.Count - i - 1; j++)
            {
                TKey first = selector(result[j]);
                TKey second = selector(result[j + 1]);

                if (first.CompareTo(second) > 0)
                {
                    T temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }
        return result;
    }
}

