using System;
using MelonLoader;
using UnityEngine;

namespace MyProject
{
    public class SimpleClearConsole:MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonLogger.Log("SimpleClearConsole is active, press F4 to clear console!");
        }

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F4)){
                Console.Clear();
            }
        }
    }
}
