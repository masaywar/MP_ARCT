using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "LoadResouces/LoadPrefabs")]
public class PrefabLoader : ResourceLoader
{
    [SerializeField] private string[] paths;
    public List<List<BaseObject>> mLoadedPrefabs;

    private WaitForSeconds waits = new WaitForSeconds(0.01f);

    public override void Initialize()
    {
        mLoadedPrefabs = new List<List<BaseObject>>();
    }

    public override void LoadResources()
    {
        foreach (var path in paths)
        {
            Resources.LoadAll<BaseObject>(path);
        }
    }
}
