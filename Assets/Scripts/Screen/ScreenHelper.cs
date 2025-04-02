using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Screen
{
    public class ScreenHelper : MonoBehaviour
    {
        public ScreenType screenType;
        public void OnClick()
        {
            ScreenManager.Instance.ShowByType(screenType);
        }
    }
}