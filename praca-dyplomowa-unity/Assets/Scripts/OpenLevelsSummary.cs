using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenLevelsSummary : MonoBehaviour
{
    public Button Open;
    public Button Close;
    public GameObject LevelsCanvas;

    private void Start()
    {
        Open.onClick.AddListener(ShowCanvas);
        Close.onClick.AddListener(HideCanvas);
    }

    void ShowCanvas()
    {
        LevelsCanvas.SetActive(true);
    }

    void HideCanvas()
    {
        LevelsCanvas.SetActive(false);
    }
}
