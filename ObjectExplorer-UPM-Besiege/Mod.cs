using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluginManager.Plugin;
using UnityEngine;

namespace ObjectExplore
{

    ///  https://github.com/spaar/besiege-modloader


    [OnGameInit]
    public class Mod : MonoBehaviour
    {
        GameObject mod = new GameObject("Object Explore - UPM Edition");
        
        void Start()
        {
            mod.AddComponent<ObjectExplorerMod.ObjectExplorer>();
            DontDestroyOnLoad(mod);
        }

    }
}
