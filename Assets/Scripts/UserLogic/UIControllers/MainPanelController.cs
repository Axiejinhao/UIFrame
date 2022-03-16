using System;
using System.Collections.Generic;
using UnityEngine;
using UIFrame;

namespace UserLogic
{
    public class MainPanelController : UIControllerBase
    {
        protected override void ControllerStart()
        {
            base.ControllerStart();
            Debug.Log("MainPanel Start");
            BindEvent();
        }

        private void BindEvent()
        {
            crtModule.FindCurrentModuleWidget("HeaderMask_S").AddOnClickListener(() =>
            {
                UIManager.Instance.PushUI(SystemDefine.HEROMSGPANEL);
            });
            crtModule.FindCurrentModuleWidget("TaskButton_F").AddOnClickListener(() =>
            {
                UIManager.Instance.PushUI(SystemDefine.TASKPANEL);
            });
            crtModule.FindCurrentModuleWidget("SystemButton_F").AddOnClickListener(() =>
            {
                UIManager.Instance.PushUI(SystemDefine.SYSTEMPANEL);
            });
            crtModule.FindCurrentModuleWidget("BagButton_F").AddOnClickListener(() =>
            {
                UIManager.Instance.PushUI(SystemDefine.HEROEQUIPPANEL);
                UIManager.Instance.PushUI(SystemDefine.BAGPANEL);
            });
        }
    }
}
