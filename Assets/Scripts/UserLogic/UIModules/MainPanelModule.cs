using System;
using System.Collections.Generic;
using UnityEngine;
using UIFrame;
using UserLogic;

namespace UserLogic
{
    public class MainPanelModule : UIModuleBase
    {
        public override void Awake()
        {
            //执行父类的Awake
            base.Awake();
            //创建控制器
            var controller = new MainPanelController();
            //绑定控制
            this.BindController(controller);
        }
    }
}
