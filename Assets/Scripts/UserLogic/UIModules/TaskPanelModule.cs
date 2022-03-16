using System;
using System.Collections.Generic;
using UnityEngine;
using UIFrame;
using DG.Tweening;

namespace UserLogic
{
    public class TaskPanelModule : UIModuleBase
    {
        public override void OnEnter()
        {
            transform.DOLocalMoveX(0, 2);
            //执行父类方法
            base.OnEnter();
        }

        public override void OnExit()
        {
            transform.DOLocalMoveX(2000, 2);
            //执行父类方法
            base.OnExit();
        }
    }
}
