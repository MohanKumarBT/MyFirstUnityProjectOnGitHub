﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Myfirstscript : MonoBehaviour
{
    public void ChangeScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }
}