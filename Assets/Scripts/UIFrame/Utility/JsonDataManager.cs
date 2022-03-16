using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UIFrame;

namespace UIFrame
{
    public class JsonDataManager : Singleton<JsonDataManager>
    {
        private JsonDataManager()
        {
            panelData = new JsonPanelsModel();
            panelDataDic = new Dictionary<int, Dictionary<string, string>>();
            ParsePanelData();
        }

        #region Saved Structure
        //Panel解析后的数据
        private JsonPanelsModel panelData;
        //Panel解析后的数据(字典版)
        private Dictionary<int, Dictionary<string, string>> panelDataDic;
        #endregion

        /// <summary>
        /// Json解析
        /// </summary>
        private void ParsePanelData()
        {
            //获取配置文本的资源
            TextAsset panelConfig = AssetsManager.Instance.GetAsset(SystemDefine.PanelConfigPath) as TextAsset;
            //将Panel的配置文件进行解析
            panelData = JsonUtility.FromJson<JsonPanelsModel>(panelConfig.text);

            //将panelData转化为字典型
            for (int i = 0; i < panelData.AllData.Length; i++)
            {
                //创建一个字典
                Dictionary<string, string> crtDic = new Dictionary<string, string>();
                //给新建的字典赋值
                for (int j = 0; j < panelData.AllData[i].Data.Length; j++)
                {
                    crtDic.Add(panelData.AllData[i].Data[j].PanelName,
                        panelData.AllData[i].Data[j].PanelPath);
                }
                //添加一个场景ID和一个字典
                panelDataDic.Add(i, crtDic);
            }
        }

        /// <summary>
        /// 通过Panel资源名称返回Panel资源路径
        /// </summary>
        /// <param name="panelName"></param>
        /// <returns></returns>
        public string FindPanelPath(string panelName, int sceneID = (int)SystemDefine.SceneID.MainScene)
        {
            if (!panelDataDic.ContainsKey(sceneID))
            {
                return null;
            }
            if (!panelDataDic[sceneID].ContainsKey(panelName))
            {
                return null;
            }
            //如果ID和资源名称都存在
            return panelDataDic[sceneID][panelName];
        }
    }
}
