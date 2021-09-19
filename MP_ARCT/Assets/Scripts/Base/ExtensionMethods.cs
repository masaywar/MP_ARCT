using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class ExtensionMethods
{
    public static void ForEach<T>(this IEnumerable<T> source, System.Action<T> action)
    {
        foreach (var e in source)
            action(e);
    }

    public static List<T> ToList<T>(this IEnumerable<T> source)
    {
        return source.ToList();
    }

    public static IEnumerable<T> ToArray<T>(this IEnumerable<T> source)
    {
        return source.ToArray();
    }

    public static IEnumerable<T> SubArray<T>(this IEnumerable<T> source, int start, int count)
    {
        return source.Skip(start).Take(count);
    }

    public static T GetTop<T>(this T[] array)
    {
        return array[array.Length - 1];
    }

    public static T Top<T>(this List<T> list)
    {
        return list[list.Count - 1];
    }

    public static IEnumerator DoWaitForSeconds(float time, System.Action action)
    {
        yield return new WaitForSeconds(time);
        action();
    }
}
