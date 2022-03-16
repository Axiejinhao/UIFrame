using System;
using System.Collections.Generic;
using UnityEngine;
using UIFrame;

namespace UserLogic
{
    public class BagPanelController : UIControllerBase
    {
        protected override void ControllerStart()
        {
            base.ControllerStart();
            BindEvent();
        }

        private void BindEvent()
        {
            for (int i = 1; i < 5; i++)
            {
                UIWidgetBase widgetBase = crtModule.FindCurrentModuleWidget(
                    "Goods" + i.ToString() + "_F");

                crtModule.FindCurrentModuleWidget("Goods" + i.ToString() + "_F").AddOnClickListener(() =>
                {
                    UIManager.Instance.PushUI(SystemDefine.NORMALWINDOWPANEL);
                    Sprite spr = widgetBase.GetSprite();
                    UIManager.Instance.FindWidget(SystemDefine.NORMALWINDOWPANEL,
                        "Image_S").SetSprite(spr);
                });
            }
        }
    }
}
