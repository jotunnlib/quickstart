using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JotunnLib;
using JotunnLib.Managers;

namespace Quickstart
{
    // **********************************************************************************
    // * You'll want to change Properties > AssemblyInfo.cs and use a new GUID string.  *
    // * You can use https://www.guidgenerator.com/                                     *
    // **********************************************************************************

    // Change the below line to match your mod.
    [BepInPlugin("com.bepinex.plugins.quickstart", "JotunnLib Quickstart Mod", "0.0.1")]
    [BepInDependency("com.bepinex.plugins.jotunnlib")]
    public class QuickstartMod : BaseUnityPlugin
    {
        public static Skills.SkillType QuickstartSkillType = 0;

        private void Awake()
        {
            QuickstartSkillType = SkillManager.Instance.RegisterSkill("Quickstart", "Let's get modding fast!");
        }
    }
}
