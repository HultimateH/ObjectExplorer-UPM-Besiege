using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PluginManager.Plugin;
using UnityEngine;

namespace ObjectExplorerMod
{

    ///  https://github.com/spaar/besiege-modloader


    [OnGameInit]
    public class Mod : MonoBehaviour
    {
        GameObject mod ;

        void Start()
        {
            mod = ObjectExplorer.Instance.gameObject;
            DontDestroyOnLoad(mod);
        }
    }
}
