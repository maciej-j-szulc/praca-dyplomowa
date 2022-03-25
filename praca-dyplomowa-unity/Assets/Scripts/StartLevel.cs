using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartLevel : MonoBehaviour
{
    private bool firstTime = true;
    public Button BeginLevel;
    public GameObject LevelStartCanvas;
    void Start()
    {
        BeginLevel.onClick.AddListener(Begin);
    }

    void Begin()
    {
            Debug.Log("Click");
            LevelStartCanvas.SetActive(false);
            Time.timeScale = 1;       
    }
}
