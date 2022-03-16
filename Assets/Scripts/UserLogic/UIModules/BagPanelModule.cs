using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UIFrame;
using DG.Tweening;

namespace UserLogic
{
    public class BagPanelModule : UIModuleBase
    {
        public override void Awake()
        {
            //执行父类的Awake
            base.Awake();
            //创建控制器
            var controller = new BagPanelController();
            //绑定控制
            this.BindController(controller);
        }

        public override void OnEnter()
        {
            _canvasGroup.DOFade(1, 1);
            base.OnEnter();
        }

        public override void OnExit()
        {
            _canvasGroup.DOFade(0, 1);
            base.OnExit();
        }
    }
}