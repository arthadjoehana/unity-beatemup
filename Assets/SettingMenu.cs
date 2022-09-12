using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer _Mixer;
    Resolution[] resolutions;
    public Dropdown resolutionDrop;

    public void Start()
    {
        resolutions = Screen.resolutions;
        resolutionDrop.ClearOptions();
        List<string> options = new List<string>();
        int currentResoltionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResoltionIndex = i;
            }
        }
        resolutionDrop.AddOptions(options);
        resolutionDrop.value = currentResoltionIndex;
        resolutionDrop.RefreshShownValue();
    }

    public void SetVolume(float Volume)
    {
        _Mixer.SetFloat("Volume", Volume);
    }
    public void setFullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}