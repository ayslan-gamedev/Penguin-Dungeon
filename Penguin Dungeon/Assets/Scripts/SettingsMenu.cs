﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SettingsMenu : MonoBehaviour
{
    public Dropdown DResolution;

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetResolution()
    {
        switch (DResolution.value)
        {
            case 0:
                Screen.SetResolution(640, 360, true);
                break;
            
            case 1:
                Screen.SetResolution(1280, 720, true);
                break;

            case 2:
                Screen.SetResolution(1366, 768, true);
                break;
        }
    }
}
