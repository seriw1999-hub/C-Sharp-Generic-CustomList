using System;
using System.Collections.Generic;

public class CustomList<T> 
{
    private List<T> internalList = new List<T>(); 

    public void Add(T item)
    {
        internalList.Add(item);
    }

    public void Remove(T item)
    {
        if (!internalList.Remove(item))
        {
            Console.WriteLine("Element not found"); 
        }
    }
    public void Clear()
    {
        internalList.Clear();
    }

    public bool Contains(T item)
    {
        return internalList.Contains(item);
    }

    public int Count()
    {
        return internalList.Count;
    }

    public void PrintAll()
    {
        foreach (var item in internalList)
        {
            Console.WriteLine(item);
        }
    }
}
