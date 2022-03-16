using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIFrame;

using Object = UnityEngine.Object;

public class Test : MonoBehaviour
{
    private void Start()
    {
        //TextAsset panelConfig = AssetsManager.Instance.GetAsset(SystemDefine.PanelConfigPath) as TextAsset;
        //Debug.Log(panelConfig.text);

        //string path = JsonDataManager.Instance.FindPanelPath("MainPanel");
        //Debug.Log(path);

        //UIManager.Instance.GetUIModule(UITypeManager.Instance.GetUIType("SystemPanel"));
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            UIManager.Instance.PopUI();

        }

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    UIWidgetBase uiWidgetBase = UIManager.Instance.FindWidget("MainPanel", "HeaderMask_S");
        //    Debug.Log(uiWidgetBase);

        //    uiWidgetBase.AddOnClickListener(() =>
        //    {
        //        Debug.Log("kkkkk");
        //    });
        //}
    }
}
