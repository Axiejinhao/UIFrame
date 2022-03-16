using System;
using System.Collections.Generic;
using UnityEngine;
using UIFrame;
using UserLogic;

namespace Facade
{
    public class GameFacade : MonoBehaviour
    {
        private void Start()
        {
            //游戏启动
            UIManager.Instance.PushUI("MainPanel");
        }

    }
}
