using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UIFrame;
using DG.Tweening;

namespace UserLogic
{
    public class HeroMsgPanelModule : UIModuleBase
    {
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