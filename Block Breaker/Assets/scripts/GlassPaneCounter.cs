﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassPaneCounter : MonoBehaviour
{
    [SerializeField] private int glassPaneCount; 
    [SerializeField] private int glassPaneCountToWin;

    private SceneLoader sceneLoader;
    void Start()
    {
        glassPaneCount = FindObjectsOfType<GlassPane>().Length;
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void reduceGlassPaneCount(){

        glassPaneCount --;
        if(glassPaneCount == glassPaneCountToWin){
            sceneLoader.LoadNextScene();
        }
    }
}