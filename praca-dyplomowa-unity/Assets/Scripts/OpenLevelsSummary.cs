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

    public Button OpenScore;
    public Button CloseScore;
    public GameObject ScoreCanvas;

    private void Start()
    {
        Open.onClick.AddListener(ShowCanvas);
        Close.onClick.AddListener(HideCanvas);
        OpenScore.onClick.AddListener(ShowScore);
        CloseScore.onClick.AddListener(HideScore);
    }

    void ShowCanvas()
    {
        LevelsCanvas.SetActive(true);
    }

    void HideCanvas()
    {
        LevelsCanvas.SetActive(false);
    }

    void ShowScore()
    {
        ScoreCanvas.SetActive(true);
    }

    void HideScore()
    {
        ScoreCanvas.SetActive(false);
    }
}
