using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResourceLoader : ScriptableObject
{
    public abstract void Initialize();
  
    public abstract void LoadResources();
}
