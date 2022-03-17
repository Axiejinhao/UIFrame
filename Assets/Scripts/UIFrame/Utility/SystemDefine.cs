﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIFrame
{
    public static class SystemDefine
    {
        #region Configuration Path
        public const string PanelConfigPath = "Configuration/UIPanelConfig";
        public const string LocalizationConfigPath = "Configuration/UILanguageTextConfig";
        #endregion

        #region Scene ID
        public enum SceneID
        {
            MainScene = 0,
            FightScene = 1
        }
        #endregion

        #region Game Tags
        public const string CANVAS = "Canvas";
        #endregion

        #region Widget Token
        public static string[] WIDGET_TOKEN = new string[] { "_F", "_S", "T" };
        #endregion

        #region PanelName
        public const string TASKPANEL = "TaskPanel";
        public const string SYSTEMPANEL = "SystemPanel";
        public const string NORMALWINDOWPANEL = "NormalWindowPanel";
        public const string MAINPANEL = "MainPanel";
        public const string HEROMSGPANEL = "HeroMsgPanel";
        public const string HEROEQUIPPANEL = "HeroEquipPanel";
        public const string BAGPANEL = "BagPanel";
        #endregion
    }
}
