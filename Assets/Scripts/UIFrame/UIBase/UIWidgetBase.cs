using System;
using System.Collections;
using System.Collections.Generic;
using UIFrame;
using UnityEngine;

namespace UIFrame
{
    public class UIWidgetBase : UIMono
    {
        //当前元件所处的模块
        private UIModuleBase currentModule;
        //临时参数
        private ArrayList tempParamters;
        /// <summary>
        /// 设置临时参数
        /// </summary>
        /// <param name="para"></param>
        public void SetTempParamter(object para)
        {
            if (tempParamters == null)
            {
                tempParamters = new ArrayList();
            }

            if (!tempParamters.Contains(para))
            {
                tempParamters.Add(para);
            }
        }

        /// <summary>
        /// 获取临时参数
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object GetTempParamter(int index)
        {
            return tempParamters[index];
        }

        public void UIWidgetInit(UIModuleBase uiModuleBase)
        {
            //设置当前元件所属的模块
            currentModule = uiModuleBase;
            //将当前元件，添加到UIManager的字典中
            UIManager.Instance.AddUIWidget(currentModule.name,name,this);
        }

        protected virtual void OnDestroy()
        {
            //将当前元件，从UIManager的字典中移除
            UIManager.Instance.RemoveUIWidget(currentModule.name,name);
        }
    }
}