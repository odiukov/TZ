﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public void LoadLevel(Settings settings)
    {
        SettingsManager.Instance.SaveSettings(settings);
        SceneManager.LoadSceneAsync(1);
    }

    public void LoadLevel(int levelNumber)
    {
        SceneManager.LoadSceneAsync(levelNumber);
    }
}