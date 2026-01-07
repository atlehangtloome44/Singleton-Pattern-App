using SingletonPattern;
using System;
using System.Collections.Generic;

public class ClientResourceListWrapper
{
    private static ClientResourceListWrapper _instance;
    private static readonly object _lock = new object();

    public List<Resource> Resources { get; private set; }

    private ClientResourceListWrapper()
    {
        Resources = new List<Resource>();
    }

    public static ClientResourceListWrapper GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ClientResourceListWrapper();
                }
            }
        }
        return _instance;
    }

    public void AddResources(List<Resource> resources)
    {
        foreach (var resource in resources)
        {
            Resources.Add(resource);
        }
    }

    public void EnumerateResources()
    {
        foreach (var resource in Resources)
        {
            Console.WriteLine(resource.ToString());
        }
    }
}
