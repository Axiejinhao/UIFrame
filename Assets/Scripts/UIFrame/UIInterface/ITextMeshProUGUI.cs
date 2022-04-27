using System;
using System.Collections.Generic;
using UnityEngine;

namespace UIFrame
{
    public interface ITextMeshProUGUI
    {
        void SetTextMeshProUGUIText(string text);
        string GetTextMeshProUGUIText();
        void SetTextMeshProUGUIColor(Color color);
    }
}
