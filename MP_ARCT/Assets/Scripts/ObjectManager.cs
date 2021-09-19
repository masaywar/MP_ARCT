using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : Singleton<ObjectManager>
{
    [SerializeField]private PrefabLoader mPrefabLoader;

    private Dictionary<string, Dictionary<int, BaseObject>> mActiveObjectDict;
    private Dictionary<string, Dictionary<int, BaseObject>> mDeactiveObjectDict;

    public Dictionary<string, Dictionary<int, BaseObject>> ActiveObjectDict { get => mActiveObjectDict;}
    public Dictionary<string, Dictionary<int, BaseObject>> DeactiveObjectDict { get => mDeactiveObjectDict;}

    private bool TryInitialize()
    {
        mActiveObjectDict = new Dictionary<string, Dictionary<int, BaseObject>>();
        mDeactiveObjectDict = new Dictionary<string, Dictionary<int, BaseObject>>();

        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    /// <param name="position"></param>
    /// <param name="rotation"></param>
    /// <param name="parent"></param>
    public void Spawn<T>(T instance, Vector3 position, Quaternion rotation, Transform parent) where T : BaseObject
    { 
        
    }

    public void Spawn<T>(T instance, Vector3 position, Quaternion rotation) where T : BaseObject
    {
        Spawn<T>(instance, position, rotation, null);
    }

    public void Spawn<T>(T instance, Vector3 position, Transform parent) where T : BaseObject
    {
        Spawn<T>(instance, position, Quaternion.identity, parent);
    }

    public void Spawn<T>(T instance, Quaternion rotation, Transform parent) where T : BaseObject
    {
        Spawn<T>(instance, Vector3.zero, rotation, parent);
    }

    public void Spawn<T>(T instance, Vector3 position) where T : BaseObject
    {
        Spawn<T>(instance, position, Quaternion.identity, null);
    }

    public void Spawn<T>(T instance, Quaternion rotation) where T : BaseObject
    {
        Spawn<T>(instance, Vector3.zero, rotation, null);
    }

    public void Spawn<T>(T instance, Transform parent) where T : BaseObject
    {
        Spawn<T>(instance, Vector3.zero, Quaternion.identity, parent);
    }

    public void Spawn<T>(T instance) where T : BaseObject
    {
        Spawn<T>(instance, Vector3.zero, Quaternion.identity, null);
    }

    public void Despawn<T>(T instance) where T : BaseObject
    { 
    
    }
}
